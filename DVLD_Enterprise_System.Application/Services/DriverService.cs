using DVLD_Enterprise_System.Application.DTOs;
using DVLD_Enterprise_System.Application.Exceptions;
using DVLD_Enterprise_System.Application.Interfaces;
using DVLD_Enterprise_System.Application.Mapping;
using DVLD_Enterprise_System.Domain.Entities;

namespace DVLD_Enterprise_System.Application.Services;

public class DriverService : IDriverService
{
    private readonly DVLD_Enterprise_System.Domain.Interfaces.IUnitOfWork _unitOfWork;

    public DriverService(DVLD_Enterprise_System.Domain.Interfaces.IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IReadOnlyList<DriverDto>> GetAllAsync()
    {
        var drivers = await _unitOfWork.Drivers.GetAllAsync();
        return drivers.Select(d => d.ToDto()).ToList();
    }

    public async Task<DriverDto> GetByIdAsync(int id)
    {
        var driver = await _unitOfWork.Drivers.GetByIdAsync(id)
            ?? throw new NotFoundException(nameof(Driver), id);

        return driver.ToDto();
    }

    public async Task<DriverDto> CreateAsync(DriverCreateDto dto)
    {
        // Validate the foreign key up front. Without this check, if PersonID
        // didn't exist, SaveChangesAsync() would still fail - but with a
        // low-level SQL "FK constraint violation" error that's confusing for
        // an API consumer. Checking first lets us throw our own clear,
        // meaningful NotFoundException instead.
        _ = await _unitOfWork.People.GetByIdAsync(dto.PersonID)
            ?? throw new NotFoundException(nameof(Person), dto.PersonID);

        var driver = new Driver
        {
            PersonID = dto.PersonID,
            CreatedByUserID = dto.CreatedByUserID,
            CreatedDate = DateTime.Now
        };

        await _unitOfWork.Drivers.AddAsync(driver);
        await _unitOfWork.SaveChangesAsync();

        return driver.ToDto();
    }
}
