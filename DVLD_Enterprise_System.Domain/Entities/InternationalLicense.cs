namespace DVLD_Enterprise_System.Domain.Entities;

/// <summary>
/// An International Driving License, which is always issued based on an
/// existing valid local License (you cannot get an international license
/// without already holding a local one).
/// </summary>
public class InternationalLicense
{
    public int InternationalLicenseID { get; set; }
    public int ApplicationID { get; set; }
    public int DriverID { get; set; }
    public int IssuedUsingLocalLicenseID { get; set; }
    public DateTime IssueDate { get; set; }
    public DateTime ExpirationDate { get; set; }
    public bool IsActive { get; set; }
    public int CreatedByUserID { get; set; }

    // ----- Navigation properties -----
    public Application Application { get; set; } = null!;
    public Driver Driver { get; set; } = null!;
    public License IssuedUsingLocalLicense { get; set; } = null!;
    public User CreatedByUser { get; set; } = null!;
}
