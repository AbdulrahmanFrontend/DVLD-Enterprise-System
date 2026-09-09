namespace DVLD_Enterprise_System.Domain.Entities;

/// <summary>
/// A lookup table describing the different kinds of applications a citizen can submit
/// (e.g. "New Local Driving License Service", "Renew Driving License Service", ...).
/// </summary>
public class ApplicationType
{
    public int ApplicationTypeID { get; set; }
    public string ApplicationTypeTitle { get; set; } = string.Empty;

    /// <summary>
    /// Maps to a SQL "smallmoney" column. "decimal" is the correct .NET type
    /// for any money/currency value - never use float or double for money,
    /// because they cannot represent decimal fractions exactly and will cause
    /// rounding errors in financial calculations.
    /// </summary>
    public decimal ApplicationFees { get; set; }
}
