namespace DVLD_Enterprise_System.Application.Exceptions;

/// <summary>
/// Thrown when a requested entity does not exist (e.g. GetById with a wrong id).
///
/// WHY A CUSTOM EXCEPTION?
/// Later, in the API layer, we will add a small piece of "middleware" that
/// catches this specific exception type and automatically converts it into an
/// HTTP 404 Not Found response. This keeps our Services clean (they just throw
/// a meaningful, business-level exception) and keeps HTTP concerns (status codes)
/// entirely out of the Application layer - another example of separation of concerns.
/// </summary>
public class NotFoundException : Exception
{
    public NotFoundException(string entityName, object key)
        : base($"{entityName} with id '{key}' was not found.")
    {
    }
}