namespace DVLD_Enterprise_System.Domain.Enums;

/// <summary>
/// Represents why a License record was issued.
/// Maps to the [IssueReason] tinyint column on the Licenses table.
/// Original DB comment: "1-FirstTime, 2-Renew, 3-Replacement for Damaged, 4-Replacement for Lost."
/// </summary>
public enum LicenseIssueReason : byte
{
    FirstTime = 1,
    Renew = 2,
    ReplacementForDamaged = 3,
    ReplacementForLost = 4
}
