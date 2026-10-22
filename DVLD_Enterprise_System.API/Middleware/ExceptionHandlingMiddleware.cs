using DVLD_Enterprise_System.Application.DTOs.Errors;
using DVLD_Enterprise_System.Application.Exceptions;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace DVLD_Enterprise_System.API.Middleware
{
    /// <summary>
    /// Global middleware responsible for catching unhandled exceptions
    /// that occur anywhere later in the HTTP request pipeline.
    ///
    /// Instead of allowing exceptions to reach ASP.NET Core and return
    /// inconsistent/default error responses, this middleware converts
    /// known exceptions into standardized API error responses.
    ///
    /// Request flow:
    ///
    /// Client
    ///    ↓
    /// Middleware
    ///    ↓
    /// Controller
    ///    ↓
    /// Service
    ///    ↓
    /// EF Core / Database
    ///
    /// If an exception occurs in any layer below the middleware:
    ///
    /// Database/Service/Controller
    ///    ↑
    /// Middleware catches the exception
    ///    ↓
    /// Converts it to an HTTP response
    ///    ↓
    /// Client receives JSON error response
    /// </summary>
    public class ExceptionHandlingMiddleware
    {
        // Represents the next component in the ASP.NET Core
        // HTTP request pipeline.
        //
        // Calling _next(context) means:
        // "Continue processing this request through the next middleware."
        private readonly RequestDelegate _next;

        // ASP.NET Core's built-in logging service.
        // Used to record exceptions for debugging and monitoring.
        private readonly ILogger<ExceptionHandlingMiddleware> _logger;

        public ExceptionHandlingMiddleware(
            RequestDelegate next,
            ILogger<ExceptionHandlingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        /// <summary>
        /// Executes this middleware for every HTTP request.
        ///
        /// The try/catch surrounds _next(context), therefore any exception
        /// thrown by middleware/controllers/services/EF Core below this
        /// middleware can be caught here.
        /// </summary>
        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                // Continue the request pipeline.
                //
                // For example:
                // Client → Middleware → Controller → Service → EF Core
                await _next(context);
            }
            catch (DbUpdateException ex)
            {
                // EF Core throws DbUpdateException when a database operation
                // such as INSERT/UPDATE/DELETE fails.
                //
                // Example:
                // - UNIQUE constraint violation
                // - CHECK constraint violation
                // - FOREIGN KEY violation
                // - other database update errors
                //
                // We log the original exception for developers/administrators.
                // The client should NOT receive the raw database exception.
                _logger.LogError(
                    ex,
                    "Database update error occurred.");

                // Convert the database exception into an appropriate
                // HTTP response.
                await HandleDatabaseExceptionAsync(context, ex);
            }
            catch (Exception ex)
            {
                // Catches all other unexpected exceptions that were not
                // specifically handled above.
                //
                // This prevents internal exception details from being
                // exposed directly to the client.
                _logger.LogError(
                    ex,
                    "Unhandled exception occurred.");

                await HandleExceptionAsync(context, ex);
            }
        }

        /// <summary>
        /// Handles exceptions produced while EF Core is saving changes
        /// to the database.
        ///
        /// DbUpdateException itself is a general EF Core exception.
        /// Therefore, we inspect its InnerException to determine the
        /// actual database error.
        /// </summary>
        private static async Task HandleDatabaseExceptionAsync(
            HttpContext context,
            DbUpdateException exception)
        {
            // Default response:
            // We do not expose the database's internal error details.
            var statusCode = StatusCodes.Status500InternalServerError;
            var message = "A database error occurred!";

            // SQL Server usually stores the actual SQL Server exception
            // inside DbUpdateException.InnerException.
            //
            // SqlException gives us information such as the SQL Server
            // error number.
            if (exception.InnerException is SqlException sqlException)
            {
                // SQL Server:
                //
                // 2601 = duplicate key / unique index violation
                // 2627 = PRIMARY KEY or UNIQUE constraint violation
                //
                // Both mean that the operation attempted to insert/update
                // a value that must be unique but already exists.
                if (sqlException.Number == 2601 ||
                    sqlException.Number == 2627)
                {
                    statusCode = StatusCodes.Status409Conflict;

                    message =
                        "A record with the same unique value already exists!";
                }
            }

            // Set the HTTP status code that will be returned to the client.
            context.Response.StatusCode = statusCode;

            // Tell the client that the response body is JSON.
            context.Response.ContentType = "application/json";

            // Build our standardized API error response.
            var response = new ApiErrorResponse
            {
                StatusCode = statusCode,
                Message = message
            };

            // Convert the C# object into JSON and send it to the client.
            await context.Response.WriteAsync(
                JsonSerializer.Serialize(response));
        }

        /// <summary>
        /// Handles application-level exceptions that are intentionally
        /// thrown by our application.
        ///
        /// Examples:
        /// NotFoundException  → 404
        /// ConflictException  → 409
        ///
        /// Unknown exceptions → 500
        /// </summary>
        private static async Task HandleExceptionAsync(
            HttpContext context,
            Exception exception)
        {
            // Default behavior for an unknown/unexpected exception.
            var statusCode = StatusCodes.Status500InternalServerError;
            var message = "An unexpected error occurred!";

            // The service can intentionally throw NotFoundException
            // when a required resource does not exist.
            if (exception is NotFoundException)
            {
                statusCode = StatusCodes.Status404NotFound;
                message = exception.Message;
            }

            // ConflictException represents a business/application conflict.
            //
            // Example:
            // "National number already exists."
            else if (exception is ConflictException)
            {
                statusCode = StatusCodes.Status409Conflict;
                message = exception.Message;
            }

            context.Response.StatusCode = statusCode;
            context.Response.ContentType = "application/json";

            var response = new ApiErrorResponse
            {
                StatusCode = statusCode,
                Message = message,
            };

            // Serialize our standardized error object into JSON.
            await context.Response.WriteAsync(
                JsonSerializer.Serialize(response));
        }
    }
}