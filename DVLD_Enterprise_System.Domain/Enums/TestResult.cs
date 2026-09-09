namespace DVLD_Enterprise_System.Domain.Enums;

/// <summary>
/// Represents the outcome of a driving Test.
/// Maps to the [TestResult] bit column on the Tests table.
/// Original DB comment: "0 - Fail 1-Pass".
///
/// NOTE: The database column is a "bit" (true/false). We could have simply used
/// a C# bool. We chose an enum instead purely for READABILITY at the call site:
/// "test.Result = TestResult.Pass;" reads better than "test.Result = true;".
/// In the Infrastructure layer (EF Core configuration), we will map this enum
/// to the underlying bit column using a simple value conversion.
/// </summary>
public enum TestResult : byte
{
    Fail = 0,
    Pass = 1
}
