using DVLD_Enterprise_System.Domain.Enums;

namespace DVLD_Enterprise_System.Domain.Entities;

/// <summary>
/// The generic "Application" (a request submitted to the DVLD by a citizen).
/// This is the most central table in the whole database: almost every business
/// process (new license, renewal, international license, retaking a test,
/// releasing a detained license) starts by creating a row here, and then a
/// specialized table (like LocalDrivingLicenseApplication) adds details specific
/// to that kind of request. This is a common relational-database pattern called
/// "table-per-type" / supertype-subtype modeling.
///
/// NAMING NOTE: We named this class "Application" to mirror the database table
/// exactly, matching the domain language used by the business (this is called
/// "Ubiquitous Language" in Domain-Driven Design). Just be aware that if you ever
/// add "using System.Windows;" in the same file it could clash with
/// System.Windows.Forms.Application - not a concern for an ASP.NET Core Web API,
/// so no action needed here.
/// </summary>
public class Application
{
    public int ApplicationID { get; set; }
    public int ApplicantPersonID { get; set; }
    public DateTime ApplicationDate { get; set; }
    public int ApplicationTypeID { get; set; }
    public ApplicationStatus ApplicationStatus { get; set; }
    public DateTime LastStatusDate { get; set; }
    public decimal PaidFees { get; set; }
    public int CreatedByUserID { get; set; }

    // ----- Navigation properties -----
    public Person ApplicantPerson { get; set; } = null!;
    public ApplicationType ApplicationType { get; set; } = null!;
    public User CreatedByUser { get; set; } = null!;
}
