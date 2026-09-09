using DVLD_Enterprise_System.Application.DTOs;
using DVLD_Enterprise_System.Application.Exceptions;
using DVLD_Enterprise_System.Application.Interfaces;
using DVLD_Enterprise_System.Application.Mapping;
using DVLD_Enterprise_System.Domain.Entities;
using DVLD_Enterprise_System.Domain.Enums;

namespace DVLD_Enterprise_System.Application.Services;

/// <summary>
/// THIS is the service that best shows why an Application layer exists at all.
/// A "CRUD-only" service just moves data around. This one encodes actual
/// business rules about how an Application is allowed to move through its
/// lifecycle: New -> Completed, or New -> Cancelled - but never
/// Completed -> Cancelled, for example.
/// </summary>
public class ApplicationService : IApplicationService
{
    private readonly DVLD_Enterprise_System.Domain.Interfaces.IUnitOfWork _unitOfWork;

    public ApplicationService(DVLD_Enterprise_System.Domain.Interfaces.IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IReadOnlyList<ApplicationDto>> GetAllAsync()
    {
        var applications = await _unitOfWork.Applications.GetAllAsync();
        return applications.Select(a => a.ToDto()).ToList();
    }

    public async Task<ApplicationDto> GetByIdAsync(int id)
    {
        var application = await _unitOfWork.Applications.GetByIdAsync(id)
            ?? throw new NotFoundException(nameof(Application), id);

        return application.ToDto();
    }

    public async Task<ApplicationDto> SubmitNewApplicationAsync(ApplicationCreateDto dto)
    {
        // Validate both foreign keys before creating the row - same reasoning
        // as in DriverService: fail early with a clear, business-level error.
        _ = await _unitOfWork.People.GetByIdAsync(dto.ApplicantPersonID)
            ?? throw new NotFoundException(nameof(Person), dto.ApplicantPersonID);

        _ = await _unitOfWork.ApplicationTypes.GetByIdAsync(dto.ApplicationTypeID)
            ?? throw new NotFoundException(nameof(ApplicationType), dto.ApplicationTypeID);

        var now = DateTime.Now;

        var application = new DVLD_Enterprise_System.Domain.Entities.Application
        {
            ApplicantPersonID = dto.ApplicantPersonID,
            ApplicationTypeID = dto.ApplicationTypeID,
            ApplicationDate = now,
            // Every new Application always starts life with status "New" -
            // the caller does NOT get to choose the initial status. This is a
            // business rule enforced right here, not left to chance in the DTO.
            ApplicationStatus = ApplicationStatus.New,
            LastStatusDate = now,
            PaidFees = dto.PaidFees,
            CreatedByUserID = dto.CreatedByUserID
        };

        await _unitOfWork.Applications.AddAsync(application);
        await _unitOfWork.SaveChangesAsync();

        return application.ToDto();
    }

    public async Task CancelApplicationAsync(int applicationId)
    {
        var application = await _unitOfWork.Applications.GetByIdAsync(applicationId)
            ?? throw new NotFoundException(nameof(Application), applicationId);

        // BUSINESS RULE: a Completed application is final and can never be cancelled.
        if (application.ApplicationStatus == ApplicationStatus.Completed)
        {
            throw new BusinessRuleException(
                "This application has already been completed and can no longer be cancelled.");
        }

        application.ApplicationStatus = ApplicationStatus.Cancelled;
        application.LastStatusDate = DateTime.Now;

        _unitOfWork.Applications.Update(application);
        await _unitOfWork.SaveChangesAsync();
    }

    public async Task CompleteApplicationAsync(int applicationId)
    {
        var application = await _unitOfWork.Applications.GetByIdAsync(applicationId)
            ?? throw new NotFoundException(nameof(Application), applicationId);

        // BUSINESS RULE: only a "New" application can transition to "Completed".
        // (A Cancelled application must never silently become Completed.)
        if (application.ApplicationStatus != ApplicationStatus.New)
        {
            throw new BusinessRuleException(
                $"Only an application with status '{ApplicationStatus.New}' can be completed. " +
                $"Current status is '{application.ApplicationStatus}'.");
        }

        application.ApplicationStatus = ApplicationStatus.Completed;
        application.LastStatusDate = DateTime.Now;

        _unitOfWork.Applications.Update(application);
        await _unitOfWork.SaveChangesAsync();
    }
}
