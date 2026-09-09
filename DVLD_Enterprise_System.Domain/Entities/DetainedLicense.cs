namespace DVLD_Enterprise_System.Domain.Entities;

/// <summary>
/// Represents a License being confiscated/detained (e.g. traffic violation),
/// and the eventual release of that license after a fine is paid (a separate
/// "Release" Application is created for that).
/// </summary>
public class DetainedLicense
{
    public int DetainID { get; set; }
    public int LicenseID { get; set; }
    public DateTime DetainDate { get; set; }
    public decimal FineFees { get; set; }
    public int CreatedByUserID { get; set; }
    public bool IsReleased { get; set; }

    /// <summary>Nullable: only has a value once the license is actually released.</summary>
    public DateTime? ReleaseDate { get; set; }

    /// <summary>Nullable: the employee who processed the release (unknown until released).</summary>
    public int? ReleasedByUserID { get; set; }

    /// <summary>Nullable: the Application created to request the release.</summary>
    public int? ReleaseApplicationID { get; set; }

    // ----- Navigation properties -----
    public License License { get; set; } = null!;
    public User CreatedByUser { get; set; } = null!;

    /// <summary>
    /// OPTIONAL REFERENCE NAVIGATION PROPERTY. Because ReleasedByUserID is
    /// nullable (int?), the matching navigation property must also be nullable
    /// (User?) rather than using "= null!". This correctly tells the compiler
    /// and EF Core that "no related User" is a valid, expected state.
    /// </summary>
    public User? ReleasedByUser { get; set; }

    public Application? ReleaseApplication { get; set; }
}
