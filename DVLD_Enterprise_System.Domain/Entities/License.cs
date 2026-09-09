using DVLD_Enterprise_System.Domain.Enums;

namespace DVLD_Enterprise_System.Domain.Entities;

/// <summary>
/// The actual, physical/legal driving license record issued to a Driver.
/// Created as the result of a successful Application (e.g. after passing all
/// required tests, or as a renewal/replacement).
/// </summary>
public class License
{
    public int LicenseID { get; set; }
    public int ApplicationID { get; set; }
    public int DriverID { get; set; }

    /// <summary>
    /// FK column. In the original SQL script this column is literally named
    /// [LicenseClass] (same name as the LicenseClasses table), which is a bit
    /// confusing. We renamed the C# property to "LicenseClassID" for clarity —
    /// this is perfectly fine; EF Core does not require C# property names to
    /// match column names as long as we tell it the mapping (we'll do that with
    /// Fluent API in the Infrastructure layer, using .HasColumnName("LicenseClass")).
    /// </summary>
    public int LicenseClassID { get; set; }

    public DateTime IssueDate { get; set; }
    public DateTime ExpirationDate { get; set; }
    public string? Notes { get; set; }
    public decimal PaidFees { get; set; }
    public bool IsActive { get; set; }
    public LicenseIssueReason IssueReason { get; set; }
    public int CreatedByUserID { get; set; }

    // ----- Navigation properties -----
    public Application Application { get; set; } = null!;
    public Driver Driver { get; set; } = null!;
    public LicenseClass LicenseClass { get; set; } = null!;
    public User CreatedByUser { get; set; } = null!;
}
