namespace DVLD_Enterprise_System.Domain.Entities;

/// <summary>
/// A scheduled appointment for an applicant to sit a particular Test, tied to
/// their LocalDrivingLicenseApplication. If they fail, they may need to submit a
/// "Retake Test" Application to book a new appointment, which is what
/// RetakeTestApplicationID points to.
/// </summary>
public class TestAppointment
{
    public int TestAppointmentID { get; set; }
    public int TestTypeID { get; set; }
    public int LocalDrivingLicenseApplicationID { get; set; }
    public DateTime AppointmentDate { get; set; }
    public decimal PaidFees { get; set; }
    public int CreatedByUserID { get; set; }

    /// <summary>Once a Test result has been recorded for this appointment, it is locked
    /// (no further changes/tests allowed against it).</summary>
    public bool IsLocked { get; set; }

    /// <summary>Nullable: only set when this appointment exists because of a "Retake Test" application.</summary>
    public int? RetakeTestApplicationID { get; set; }

    // ----- Navigation properties -----
    public TestType TestType { get; set; } = null!;
    public LocalDrivingLicenseApplication LocalDrivingLicenseApplication { get; set; } = null!;
    public User CreatedByUser { get; set; } = null!;
    public Application? RetakeTestApplication { get; set; }
}
