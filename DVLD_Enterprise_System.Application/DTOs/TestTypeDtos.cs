namespace DVLD_Enterprise_System.Application.DTOs;

public record TestTypeDto(int TestTypeID, string TestTypeTitle, string TestTypeDescription, decimal TestTypeFees);

public record TestTypeCreateDto(string TestTypeTitle, string TestTypeDescription, decimal TestTypeFees);
