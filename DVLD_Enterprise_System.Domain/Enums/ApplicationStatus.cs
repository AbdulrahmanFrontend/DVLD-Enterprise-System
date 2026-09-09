namespace DVLD_Enterprise_System.Domain.Enums;

/// <summary>
/// Represents the lifecycle status of an Application.
/// Maps to the [ApplicationStatus] tinyint column on the Applications table.
/// Original DB comment: "1-New 2-Cancelled 3-Completed".
/// </summary>
public enum ApplicationStatus : byte
{
    New = 1,
    Cancelled = 2,
    Completed = 3
}
