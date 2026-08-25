using DVLD_Enterprise_System.Application.Services.Countries;
using Microsoft.AspNetCore.Mvc;

namespace DVLD_Enterprise_System.API.Controllers
{
    /// <summary>
    /// Provides read-only access to countries.
    ///
    /// Countries are reference/master data in this system.
    /// They can be read by clients, but they are not created,
    /// updated, or deleted through this API.
    /// </summary>
    [Route("api/Countries")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        // The controller does not access EF Core or the database directly.
        //
        // It communicates with the application/service layer through
        // the abstraction ICountryService.
        private readonly ICountryService _countryService;

        public CountriesController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        /// <summary>
        /// Returns all available countries.
        ///
        /// HTTP:
        /// GET /api/Countries
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            // The controller delegates the actual operation to the service.
            //
            // Controller responsibility:
            // HTTP request/response handling.
            //
            // Service responsibility:
            // Application/data retrieval logic.
            var countries = await _countryService.GetAllAsync();

            // 200 OK + countries JSON.
            return Ok(countries);
        }

        /// <summary>
        /// Returns a specific country by ID.
        ///
        /// HTTP:
        /// GET /api/Countries/{id}
        ///
        /// Example:
        /// GET /api/Countries/51
        /// </summary>
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var country = await _countryService.GetByIdAsync(id);

            // The requested country does not exist.
            if (country == null)
                return NotFound();

            // 200 OK + country JSON.
            return Ok(country);
        }

        /*
         * The following operations intentionally do not exist
         * as active API endpoints.
         *
         * Countries are read-only according to the system requirements.
         *
         * Therefore:
         *
         * GET    → Allowed
         * POST   → Not allowed
         * PUT    → Not allowed
         * DELETE → Not allowed
         *
         * The commented code is kept only as a reference during development.
         */
    }
}