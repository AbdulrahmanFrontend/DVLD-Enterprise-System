using DVLD_Enterprise_System.API.DTOs.Countries;
using DVLD_Enterprise_System.API.Services.Countries;
using DVLD_Enterprise_System.Infrastructure.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DVLD_Enterprise_System.API.Controllers
{
    [Route("api/Countries")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private readonly ICountryService _countryService;

        public CountriesController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var countries = await _countryService.GetAllAsync();

            return Ok(countries);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var country = await _countryService.GetByIdAsync(id);

            if (country == null)
                return NotFound();

            return Ok(country);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCountryDto dto)
        {
            var country = await _countryService.CreateAsync(dto);

            return CreatedAtAction(
                nameof(GetById),
                new { id = country.CountryID },
                country);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(
            int id,
            UpdateCountryDto dto)
        {
            var updated = await _countryService.UpdateAsync(id, dto);

            if (!updated)
                return NotFound();

            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleted = await _countryService.DeleteAsync(id);

            if (!deleted)
                return NotFound();

            return NoContent();
        }
    }
}
