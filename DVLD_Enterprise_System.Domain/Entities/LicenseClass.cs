namespace DVLD_Enterprise_System.Domain.Entities;

/// <summary>
/// A lookup table describing the different classes of driving license
/// (e.g. Motorcycle, Ordinary car, Commercial, Truck...), each with its own
/// minimum age, validity period, and fees.
/// </summary>
public class LicenseClass
{
    public int LicenseClassID { get; set; }
    public string ClassName { get; set; } = string.Empty;
    public string ClassDescription { get; set; } = string.Empty;
    public byte MinimumAllowedAge { get; set; }

    /// <summary>How many years a license of this class remains valid before it expires.</summary>
    public byte DefaultValidityLength { get; set; }

    public decimal ClassFees { get; set; }
}
