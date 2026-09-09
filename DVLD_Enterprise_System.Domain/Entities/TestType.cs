namespace DVLD_Enterprise_System.Domain.Entities;

/// <summary>
/// A lookup table of the kinds of tests an applicant must pass
/// (Vision Test, Written/Theory Test, Practical/Street Test).
/// </summary>
public class TestType
{
    public int TestTypeID { get; set; }
    public string TestTypeTitle { get; set; } = string.Empty;
    public string TestTypeDescription { get; set; } = string.Empty;
    public decimal TestTypeFees { get; set; }
}
