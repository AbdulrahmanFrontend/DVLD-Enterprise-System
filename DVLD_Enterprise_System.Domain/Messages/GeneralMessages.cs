namespace DVLD_Enterprise_System.Domain.Messages;

public static class GeneralMessages
{
    public static string Required(string field) => $"{field} is required!";
    public static string MaxLength(string field, int length)
        => $"{field} must be less than or equal to {length} characters!";
    public static string Invalid(string field) => $"Invalid {field}!";
    public static string AlreadyExists(string field) => $"{field} already exists!";
}
