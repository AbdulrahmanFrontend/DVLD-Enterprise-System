namespace DVLD_Enterprise_System.Application.DTOs;

public record DriverDto(int DriverID, int PersonID, DateTime CreatedDate);

public record DriverCreateDto(int PersonID, int CreatedByUserID);
