using DVLD_Enterprise_System.Application.DTOs.Countries;
using DVLD_Enterprise_System.Application.Interfaces;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace DVLD_Enterprise_System.Application.Services.Countries;

/// <summary>
/// Contains application-level operations related to countries.
///
/// Countries are read-only reference data in the system.
///
/// This service coordinates the operation between the API layer
/// and the country repository without exposing Infrastructure
/// implementation details to the API.
/// </summary>
public class CountryService : ICountryService
{
    private readonly IAppDbContext _context;

    public CountryService(IAppDbContext countryRepository)
    {
        _context = countryRepository;
    }

    /// <summary>
    /// Retrieves all countries and maps Domain entities to DTOs.
    /// </summary>
    public async Task<IEnumerable<CountryDto>> GetAllAsync()
    {
        var countries = await _context.Countries
            .Select(c => c.Adapt<CountryDto>())
            .AsNoTracking()
            .ToListAsync();

        return countries;
    }

    /// <summary>
    /// Retrieves a country by ID and maps it to a DTO.
    ///
    /// Returns null when the country does not exist.
    /// </summary>
    public async Task<CountryDto?> GetByIdAsync(int id)
    {
        var country = await _context.Countries
            .AsNoTracking()
            .FirstOrDefaultAsync(c => c.CountryID == id);

        return country?.Adapt<CountryDto>();
    }
}
