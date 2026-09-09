namespace DVLD_Enterprise_System.Application.DTOs;

public record LicenseClassDto(
    int LicenseClassID,
    string ClassName,
    string ClassDescription,
    byte MinimumAllowedAge,
    byte DefaultValidityLength,
    decimal ClassFees);

public record LicenseClassCreateDto(
    string ClassName,
    string ClassDescription,
    byte MinimumAllowedAge,
    byte DefaultValidityLength,
    decimal ClassFees);
