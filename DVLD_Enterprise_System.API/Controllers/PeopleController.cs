using DVLD_Enterprise_System.API.DTOs.People;
using DVLD_Enterprise_System.API.Services.People;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DVLD_Enterprise_System.API.Controllers
{
    [Route("api/People")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PeopleController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var people = await _personService.GetAllAsync();

            return Ok(people);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var person = await _personService.GetByIdAsync(id);

            if (person == null)
                return NotFound();

            return Ok(person);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreatePersonDto dto)
        {
            var person = await _personService.CreateAsync(dto);

            return CreatedAtAction(
                nameof(GetById),
                new { id = person.PersonID },
                person);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, UpdatePersonDto dto)
        {
            var person = await _personService.UpdateAsync(id, dto);

            if (person == null)
                return NotFound();

            return Ok(person);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleted = await _personService.DeleteAsync(id);

            if (!deleted)
                return NotFound();

            return NoContent();
        }
    }
}
