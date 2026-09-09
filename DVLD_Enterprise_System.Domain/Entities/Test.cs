using DVLD_Enterprise_System.Domain.Enums;

namespace DVLD_Enterprise_System.Domain.Entities;

/// <summary>
/// The recorded result of a Test that was actually taken during a TestAppointment.
/// </summary>
public class Test
{
    public int TestID { get; set; }
    public int TestAppointmentID { get; set; }
    public TestResult TestResult { get; set; }
    public string? Notes { get; set; }
    public int CreatedByUserID { get; set; }

    // ----- Navigation properties -----
    public TestAppointment TestAppointment { get; set; } = null!;
    public User CreatedByUser { get; set; } = null!;
}
