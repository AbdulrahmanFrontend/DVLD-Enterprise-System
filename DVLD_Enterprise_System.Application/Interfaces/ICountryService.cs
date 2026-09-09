using DVLD_Enterprise_System.Application.DTOs;

namespace DVLD_Enterprise_System.Application.Interfaces;

/// <summary>
/// Defines the use-cases the outside world (the API layer) can ask for
/// regarding Countries. The API layer will depend on THIS interface, never on
/// the concrete CountryService class directly - that's what allows Dependency
/// Injection to swap implementations (e.g. for unit testing with a fake/mock)
/// without changing a single line of Controller code.
/// </summary>
public interface ICountryService
{
    Task<IReadOnlyList<CountryDto>> GetAllAsync();
    Task<CountryDto> GetByIdAsync(int id);
    Task<CountryDto> CreateAsync(CountryCreateDto dto);
}
