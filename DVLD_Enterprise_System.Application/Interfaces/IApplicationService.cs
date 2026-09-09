using DVLD_Enterprise_System.Application.DTOs;

namespace DVLD_Enterprise_System.Application.Interfaces;

/// <summary>
/// This is the "richest" service in this batch: unlike the simple lookup
/// tables (Country, ApplicationType), an Application has a real LIFECYCLE
/// (New -> Completed / Cancelled) with rules about what transitions are
/// allowed. Notice the method names describe BUSINESS ACTIONS
/// (SubmitNewApplicationAsync, CancelApplicationAsync, CompleteApplicationAsync)
/// rather than generic verbs (Create/Update). This is intentional: a good
/// Application-layer service reads like a description of what the business
/// actually does, not like a database CRUD screen.
/// </summary>
public interface IApplicationService
{
    Task<IReadOnlyList<ApplicationDto>> GetAllAsync();
    Task<ApplicationDto> GetByIdAsync(int id);
    Task<ApplicationDto> SubmitNewApplicationAsync(ApplicationCreateDto dto);
    Task CancelApplicationAsync(int applicationId);
    Task CompleteApplicationAsync(int applicationId);
}
