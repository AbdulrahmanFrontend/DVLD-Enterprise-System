namespace DVLD_Enterprise_System.Application.Exceptions;

/// <summary>
/// Thrown when an operation is requested that violates a business rule
/// (e.g. trying to complete an application that was already cancelled).
/// Will be mapped to HTTP 400 Bad Request in the API layer.
/// </summary>
public class BusinessRuleException : Exception
{
    public BusinessRuleException(string message) : base(message)
    {
    }
}
