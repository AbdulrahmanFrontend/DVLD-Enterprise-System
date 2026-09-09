namespace DVLD_Enterprise_System.Application.DTOs;

public record ApplicationTypeDto(int ApplicationTypeID, string ApplicationTypeTitle, decimal ApplicationFees);

public record ApplicationTypeCreateDto(string ApplicationTypeTitle, decimal ApplicationFees);
