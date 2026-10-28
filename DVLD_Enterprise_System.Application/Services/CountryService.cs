using DVLD_Enterprise_System.Application.DTOs.Countries;
using DVLD_Enterprise_System.Application.Interfaces;
using Mapster;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;

namespace DVLD_Enterprise_System.Application.Services;

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
    private IMemoryCache _cache;

    private const string AllCountriesCacheKey = "cache_countries_all";

    public CountryService(IAppDbContext countryRepository, IMemoryCache cache)
    {
        _context = countryRepository;
        _cache = cache;
    }

    /// <summary>
    /// Retrieves all countries and maps Domain entities to DTOs.
    /// </summary>
    public async Task<IEnumerable<CountryDto>> GetAllAsync()
    {
        // 1. محاولة جلب البيانات من الذاكرة المؤقتة أولاً (Cache Hit)
        if (_cache.TryGetValue(
            AllCountriesCacheKey, 
            out IEnumerable<CountryDto>? cachedCountries))
            return cachedCountries!;

        // 2. إذا لم تكن موجودة، جلبها من قاعدة البيانات (Cache Miss)
        var countries = await _context.Countries
            .Select(c => c.Adapt<CountryDto>())
            .AsNoTracking()
            .ToListAsync();

        // 3. تحديد مدة صلاحية الكاش (الدول بيانات ثابتة، لذا ساعتان مدة ممتازة)
        var cacheOptions = new MemoryCacheEntryOptions()
            .SetAbsoluteExpiration(TimeSpan.FromHours(2))  // تنتهي كلياً بعد ساعتين
            .SetSlidingExpiration(TimeSpan.FromMinutes(30)); // تُجدد لو تم طلبها بانتظام

        // 4. حفظ القائمة في الكاش للطلبات القادمة
        _cache.Set(AllCountriesCacheKey, countries, cacheOptions);

        return countries;
    }

    /// <summary>
    /// Retrieves a country by ID by filtering from the cached collection, 
    /// ensuring high performance and zero redundant cache keys.
    /// </summary>
    public async Task<CountryDto?> GetByIdAsync(int id)
    {
        // استدعاء دالة GetAllAsync يضمن لنا أن القائمة ستكون موجودة في الكاش (أو تُجلب من الداتابيز مرة واحدة)
        var countries = await GetAllAsync();

        // البحث السريع داخل القائمة الموجودة في الذاكرة (RAM) بدون أي استعلام إضافي للداتابيز
        return countries.FirstOrDefault(c => c.CountryID == id);
    }
}
