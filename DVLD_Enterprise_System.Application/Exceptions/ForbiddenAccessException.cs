namespace DVLD_Enterprise_System.Application.Exceptions;

public class ForbiddenAccessException : Exception
{
    public ForbiddenAccessException(string message) : base(message)
    {
    }
}