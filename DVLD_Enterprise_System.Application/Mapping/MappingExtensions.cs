using DVLD_Enterprise_System.Application.DTOs;
using DVLD_Enterprise_System.Domain.Entities;

namespace DVLD_Enterprise_System.Application.Mapping;

/// <summary>
/// MANUAL MAPPING between Domain Entities and Application DTOs.
///
/// You will often hear about AutoMapper, a popular NuGet package that generates
/// this mapping code for you via configuration/conventions. We are intentionally
/// NOT using it here while you're learning:
///   - It's one less "magic" library to understand — you can see exactly what
///     maps to what, and step through it in the debugger.
///   - For a project this size, explicit mapping methods are barely more typing.
/// Once you're comfortable, introducing AutoMapper (or the newer, faster
/// Mapperly source generator) is a natural and easy upgrade later — you would
/// simply delete this file and add attributes/profiles instead.
///
/// These are C# EXTENSION METHODS ("this Country country" in the signature).
/// They let you write "myCountryEntity.ToDto()" as if ToDto() were a method
/// that Country itself defined, even though it's really just a static method
/// living here. Very common pattern for mapping code.
/// </summary>
public static class MappingExtensions
{
    // ---------- Country ----------
    public static CountryDto ToDto(this Country country) =>
        new(country.CountryID, country.CountryName);

    // ---------- ApplicationType ----------
    public static ApplicationTypeDto ToDto(this ApplicationType type) =>
        new(type.ApplicationTypeID, type.ApplicationTypeTitle, type.ApplicationFees);

    // ---------- LicenseClass ----------
    public static LicenseClassDto ToDto(this LicenseClass licenseClass) =>
        new(licenseClass.LicenseClassID, licenseClass.ClassName, licenseClass.ClassDescription,
            licenseClass.MinimumAllowedAge, licenseClass.DefaultValidityLength, licenseClass.ClassFees);

    // ---------- TestType ----------
    public static TestTypeDto ToDto(this TestType testType) =>
        new(testType.TestTypeID, testType.TestTypeTitle, testType.TestTypeDescription, testType.TestTypeFees);

    // ---------- Person ----------
    public static PersonDto ToDto(this Person person) => new(
        person.PersonID,
        person.NationalNo,
        person.FirstName,
        person.SecondName,
        person.ThirdName,
        person.LastName,
        person.DateOfBirth,
        person.Gender,
        person.Address,
        person.Phone,
        person.Email,
        person.NationalityCountryID,
        person.ImagePath);

    /// <summary>Builds a brand-new Person entity out of a creation DTO (no PersonID - the DB assigns it).</summary>
    public static Person ToEntity(this PersonCreateDto dto) => new()
    {
        NationalNo = dto.NationalNo,
        FirstName = dto.FirstName,
        SecondName = dto.SecondName,
        ThirdName = dto.ThirdName,
        LastName = dto.LastName,
        DateOfBirth = dto.DateOfBirth,
        Gender = dto.Gender,
        Address = dto.Address,
        Phone = dto.Phone,
        Email = dto.Email,
        NationalityCountryID = dto.NationalityCountryID,
        ImagePath = dto.ImagePath
    };

    // ---------- Driver ----------
    public static DriverDto ToDto(this Driver driver) =>
        new(driver.DriverID, driver.PersonID, driver.CreatedDate);

    // ---------- Application ----------
    // NOTE: our entity is called "Application" and our project/namespace is
    // called "DVLD.Application" - same word, different things! Because we
    // imported "using DVLD.Domain.Entities;" above, the bare name "Application"
    // below correctly resolves to the entity class, not the namespace (a
    // namespace name alone is never treated as a type). If this ever feels
    // ambiguous while you're reading code, you can always disambiguate with a
    // "using Entity = DVLD.Domain.Entities.Application;" alias at the top of a file.
    public static ApplicationDto ToDto(this DVLD_Enterprise_System.Domain.Entities.Application application) => new(
        application.ApplicationID,
        application.ApplicantPersonID,
        application.ApplicationDate,
        application.ApplicationTypeID,
        application.ApplicationStatus,
        application.LastStatusDate,
        application.PaidFees,
        application.CreatedByUserID);
}
