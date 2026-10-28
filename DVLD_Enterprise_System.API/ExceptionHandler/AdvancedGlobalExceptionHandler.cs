using DVLD_Enterprise_System.Application.Exceptions;
using FluentValidation;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace DVLD_Enterprise_System.API.ExceptionHandler;

public class AdvancedGlobalExceptionHandler : IExceptionHandler
{
    private readonly ILogger<AdvancedGlobalExceptionHandler> _logger;
    private readonly IHostEnvironment _env;

    // 1. حقن خدمات الـ Logger للتسجيل، و IHostEnvironment لمعرفة هل نحن في بيئة التطوير أم الإنتاج
    public AdvancedGlobalExceptionHandler(
        ILogger<AdvancedGlobalExceptionHandler> logger,
        IHostEnvironment env)
    {
        _logger = logger;
        _env = env;
    }

    public async ValueTask<bool> TryHandleAsync(
        HttpContext httpContext,
        Exception exception,
        CancellationToken cancellationToken)
    {
        // 2. الحصول على معرف التتبع الفريد لكل طلب HTTP للربط بين الخطأ في الـ Logs وشكوى العميل
        var traceId = httpContext.TraceIdentifier;

        var statusCode = StatusCodes.Status500InternalServerError;
        var title = "Internal Server Error";
        string message = "An unexpected error occurred. Please try again later.";
        IDictionary<string, string[]>? errors = null;

        // 3. فحص نوع الاستثناء القادم لتحديد كود الـ HTTP المناسب وطبيعة الرسالة
        switch (exception)
        {
            case NotFoundException notFound:
                statusCode = StatusCodes.Status404NotFound;
                title = "Not Found";
                message = notFound.Message;
                _logger.LogWarning(notFound, "Not Found Exception [TraceId: {TraceId}]", traceId);
                break;

            case ConflictException conflict:
                statusCode = StatusCodes.Status409Conflict;
                title = "Conflict";
                message = conflict.Message;
                _logger.LogWarning(conflict, "Conflict Exception [TraceId: {TraceId}]", traceId);
                break;

            case BusinessRuleException businessRule:
                statusCode = StatusCodes.Status400BadRequest;
                title = "Bad Request";
                message = businessRule.Message;
                _logger.LogWarning(businessRule, "Business Rule Exception [TraceId: {TraceId}]", traceId);
                break;

            case ValidationException validationEx:
                statusCode = StatusCodes.Status400BadRequest;
                title = "Validation Failed";
                message = "One or more validation errors occurred.";
                // تجميع أخطاء التحقق لكل حقل على حدة لتسهيل عرضها في الواجهة الأمامية
                errors = validationEx.Errors
                    .GroupBy(e => e.PropertyName)
                    .ToDictionary(g => g.Key, g => g.Select(e => e.ErrorMessage).ToArray());
                _logger.LogWarning(validationEx, "Validation Exception [TraceId: {TraceId}]", traceId);
                break;

            case DbUpdateException dbEx:
                statusCode = StatusCodes.Status500InternalServerError;
                message = "A database error occurred while saving changes.";
                // فحص ما إذا كان الخطأ ناتجاً عن تكرار مفتاح فريد في قاعدة البيانات (مثل Duplicate National No)
                if (dbEx.InnerException is SqlException sqlEx && (sqlEx.Number == 2601 || sqlEx.Number == 2627))
                {
                    statusCode = StatusCodes.Status409Conflict;
                    title = "Conflict";
                    message = "A record with the same unique value already exists.";
                }
                _logger.LogError(dbEx, "Database Error [TraceId: {TraceId}]", traceId);
                break;

            default:
                // الخطأ غير معروف تماماً (يُسجل كـ Error خطير)
                _logger.LogError(exception, "Unhandled Exception [TraceId: {TraceId}]", traceId);
                break;
        }

        // 4. ضبط حالة الاستجابة ونوع المحتوى إلى JSON
        httpContext.Response.StatusCode = statusCode;
        httpContext.Response.ContentType = "application/json";

        // 5. إذا كانت هناك أخطاء Validation، نرجع ValidationProblemDetails المتخصصة بالحقول
        if (errors != null)
        {
            var validationProblem = new ValidationProblemDetails(errors)
            {
                Status = statusCode,
                Title = title,
                Detail = message,
                Instance = httpContext.Request.Path
            };
            validationProblem.Extensions["traceId"] = traceId;

            if (_env.IsDevelopment())
            {
                validationProblem.Extensions["stackTrace"] = exception.StackTrace;
            }

            await httpContext.Response.WriteAsJsonAsync(validationProblem, cancellationToken);
        }
        else
        {
            // 6. للأخطاء العادية، نرجع ProblemDetails القياسي
            var problemDetails = new ProblemDetails
            {
                Status = statusCode,
                Title = title,
                Detail = message,
                Instance = httpContext.Request.Path
            };
            problemDetails.Extensions["traceId"] = traceId;

            // إظهار الـ StackTrace فقط في بيئة التطوير لمساعدة المطورين
            if (_env.IsDevelopment())
            {
                problemDetails.Extensions["stackTrace"] = exception.StackTrace;
            }

            await httpContext.Response.WriteAsJsonAsync(problemDetails, cancellationToken);
        }

        // 7. إرجاع True تعني أننا قمنا بالتعامل مع الخطأ بنجاح ولم يعد هناك داعي لاستمرار الـ Pipeline
        return true;
    }
}
