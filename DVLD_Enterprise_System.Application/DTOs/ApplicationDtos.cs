using DVLD_Enterprise_System.Domain.Enums;

namespace DVLD_Enterprise_System.Application.DTOs;

public record ApplicationDto(
    int ApplicationID,
    int ApplicantPersonID,
    DateTime ApplicationDate,
    int ApplicationTypeID,
    ApplicationStatus ApplicationStatus,
    DateTime LastStatusDate,
    decimal PaidFees,
    int CreatedByUserID);

/// <summary>
/// What a client sends to submit a new Application.
/// Notice ApplicationDate, ApplicationStatus and LastStatusDate are NOT here -
/// those are set by the SERVER (the ApplicationService), not chosen by the caller.
/// This is an important API design principle: never let the client dictate values
/// that represent server-controlled state or audit information.
/// </summary>
public record ApplicationCreateDto(
    int ApplicantPersonID,
    int ApplicationTypeID,
    decimal PaidFees,
    int CreatedByUserID);
