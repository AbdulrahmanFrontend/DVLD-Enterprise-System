namespace DVLD_Enterprise_System.Application.Common;

public class Result<T>
{
    public bool IsSuccess { get; }
    public T? Value { get; }
    public string? ErrorMessage { get; }

    private Result(bool isSuccess, T? value, string? errorMessage)
    {
        IsSuccess = isSuccess;
        Value = value;
        ErrorMessage = errorMessage;
    }

    public static Result<T> Success(T value, string? errorMessage = null)
        => new Result<T>(true, value, errorMessage);

    public static Result<T> Failure(string? errorMessage = null)
        => new Result<T>(false, default(T), errorMessage);
}

public class Result
{
    public bool IsSuccess { get; }
    public string? Message { get; }

    private Result(bool isSuccess, string? errorMessage)
    {
        IsSuccess = isSuccess;
        Message = errorMessage;
    }

    public static Result Success(string? errorMessage = null)
        => new Result(true, errorMessage);

    public static Result Failure(string? errorMessage = null)
        => new Result(false, errorMessage);
}
