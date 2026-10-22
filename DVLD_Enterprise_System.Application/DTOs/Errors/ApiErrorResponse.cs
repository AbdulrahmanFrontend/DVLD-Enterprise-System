namespace DVLD_Enterprise_System.Application.DTOs.Errors
{
    public class ApiErrorResponse
    {
        public int StatusCode { get; set; }

        public string? Message { get; set; }

        public string? Details { get; set; }
    }
}
