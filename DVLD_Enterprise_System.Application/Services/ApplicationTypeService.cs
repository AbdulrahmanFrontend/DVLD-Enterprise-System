using DVLD_Enterprise_System.Application.DTOs;
using DVLD_Enterprise_System.Application.Exceptions;
using DVLD_Enterprise_System.Application.Interfaces;
using DVLD_Enterprise_System.Application.Mapping;
using DVLD_Enterprise_System.Domain.Entities;

namespace DVLD_Enterprise_System.Application.Services;

/// <summary>Same simple lookup-table pattern as CountryService - study both together.</summary>
public class ApplicationTypeService : IApplicationTypeService
{
    private readonly DVLD_Enterprise_System.Domain.Interfaces.IUnitOfWork _unitOfWork;

    public ApplicationTypeService(DVLD_Enterprise_System.Domain.Interfaces.IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IReadOnlyList<ApplicationTypeDto>> GetAllAsync()
    {
        var types = await _unitOfWork.ApplicationTypes.GetAllAsync();
        return types.Select(t => t.ToDto()).ToList();
    }

    public async Task<ApplicationTypeDto> GetByIdAsync(int id)
    {
        var type = await _unitOfWork.ApplicationTypes.GetByIdAsync(id)
            ?? throw new NotFoundException(nameof(ApplicationType), id);

        return type.ToDto();
    }

    public async Task<ApplicationTypeDto> CreateAsync(ApplicationTypeCreateDto dto)
    {
        var type = new ApplicationType
        {
            ApplicationTypeTitle = dto.ApplicationTypeTitle,
            ApplicationFees = dto.ApplicationFees
        };

        await _unitOfWork.ApplicationTypes.AddAsync(type);
        await _unitOfWork.SaveChangesAsync();

        return type.ToDto();
    }
}
