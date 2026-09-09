namespace DVLD_Enterprise_System.Domain.Entities;

/// <summary>
/// The "subtype" details for an Application whose ApplicationType is about a
/// local driving license (new/renew/replace). It links a generic Application
/// to the specific LicenseClass being requested.
/// </summary>
public class LocalDrivingLicenseApplication
{
    public int LocalDrivingLicenseApplicationID { get; set; }
    public int ApplicationID { get; set; }
    public int LicenseClassID { get; set; }

    public Application Application { get; set; } = null!;
    public LicenseClass LicenseClass { get; set; } = null!;
}
