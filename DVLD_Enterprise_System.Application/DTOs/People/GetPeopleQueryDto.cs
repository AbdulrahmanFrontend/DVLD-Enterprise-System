using DVLD_Enterprise_System.Domain.Enums;

namespace DVLD_Enterprise_System.Application.DTOs.People;

public sealed record GetPeopleQueryDto(string? nationalNo, string? firstName,
    string? lastName, string? phoneNumber, string? email, GenderType? gender,
    int? nationalityCountryId, int pageNumber = 1, int pageSize = 50);
