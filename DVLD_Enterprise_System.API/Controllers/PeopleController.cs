using DVLD_Enterprise_System.API.Models;
using DVLD_Enterprise_System.Application.Common;
using DVLD_Enterprise_System.Application.DTOs.People;
using DVLD_Enterprise_System.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DVLD_Enterprise_System.API.Controllers
{
    /// <summary>
    /// Handles HTTP requests related to people.
    /// </summary>
    [Route("api/People")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PeopleController(IPersonService personService)
        {
            _personService = personService;
        }

        /// <summary>
        /// Returns filtered, paginated list of people.
        /// HTTP: GET /api/People/filtered
        /// </summary>
        [HttpGet("filtered")]
        public async Task<ActionResult<PagedResult<FilteredPeopleDto>>> GetFilteredPeople(
            [FromQuery] GetPeopleQueryDto queryDto,
            CancellationToken cancellation = default)
        {
            var result = await _personService.GetFilteredPeopleAsync(queryDto, cancellation);
            return Ok(result);
        }

        /// <summary>
        /// Returns a specific person by ID.
        /// HTTP: GET /api/People/{id}
        /// </summary>
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(
            int id, 
            CancellationToken cancellation = default)
        {
            var person = await _personService.GetByIdAsync(id, cancellation);

            if (person == null)
                return NotFound();

            return Ok(person);
        }

        /// <summary>
        /// Returns a specific person by National Number.
        /// HTTP: GET /api/People/national-no/{nationalNo}
        /// </summary>
        [HttpGet("national-no/{nationalNo}")]
        public async Task<IActionResult> GetByNationalNo(
            string nationalNo, 
            CancellationToken cancellation = default)
        {
            var person = await _personService.GetByNationalNoAsync(nationalNo, cancellation);

            if (person == null)
                return NotFound();

            return Ok(person);
        }

        /// <summary>
        /// Returns a specific person by Email.
        /// HTTP: GET /api/People/email/{email}
        /// </summary>
        [HttpGet("email/{email}")]
        public async Task<IActionResult> GetByEmail(
            string email,
            CancellationToken cancellation = default)
        {
            var person = await _personService.GetByEmailAsync(email, cancellation);

            if (person == null)
                return NotFound();

            return Ok(person);
        }

        /// <summary>
        /// Creates a new person.
        /// HTTP: POST /api/People
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> Create(
            [FromForm] CreatePersonApiRequestModel model,
            CancellationToken cancellation = default)
        {
            var dto = new CreatePersonDto
            {
                NationalNo = model.NationalNo,
                FirstName = model.FirstName,
                SecondName = model.SecondName,
                ThirdName = model.ThirdName,
                LastName = model.LastName,
                DateOfBirth = model.DateOfBirth,
                NationalityCountryID = model.NationalityCountryID,
                Gender = model.Gender,
                Address = model.Address,
                Phone = model.Phone,
                Email = model.Email,
                ImageStream = model.ImageFile?.OpenReadStream(),
                ImageFileName = model.ImageFile?.FileName,
            };

            var result = await _personService.CreateAsync(dto, cancellation);

            if (!result.IsSuccess)
                return BadRequest(result.Message);

            // جلب الشخص المضاف حديثاً لإرجاعه في الـ CreatedAtAction
            var createdPerson = await _personService
                .GetByNationalNoAsync(dto.NationalNo, cancellation);

            return CreatedAtAction(
                nameof(GetById),
                new { id = createdPerson?.PersonID },
                createdPerson);
        }

        /// <summary>
        /// Updates an existing person.
        /// HTTP: PUT /api/People/{id}
        /// </summary>
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(
            int id,
            [FromForm] UpdatePersonApiRequestModel model,
            CancellationToken cancellation = default)
        {
            bool exists = await _personService.ExistsAsync(id, cancellation);

            if (!exists)
                return NotFound();

            var dto = new UpdatePersonDto
            {
                NationalNo = model.NationalNo,
                FirstName = model.FirstName,
                SecondName = model.SecondName,
                ThirdName = model.ThirdName,
                LastName = model.LastName,
                DateOfBirth = model.DateOfBirth,
                NationalityCountryID = model.NationalityCountryID,
                Gender = model.Gender,
                Address = model.Address,
                Phone = model.Phone,
                Email = model.Email,
                ImageStream = model.ImageFile?.OpenReadStream(),
                ImageFileName = model.ImageFile?.FileName,
            };

            var result = await _personService.UpdateAsync(id, dto, cancellation);

            if (!result.IsSuccess)
                return BadRequest(result.Message);

            var updatedPerson = await _personService.GetByIdAsync(id, cancellation);
            return Ok(updatedPerson);
        }

        /// <summary>
        /// Check exists by id
        /// HTTP: GET /api/People/exists/id/{id:int}
        /// </summary>
        [HttpGet("exists/id/{id:int}")]
        public async Task<IActionResult> CheckExistsByIdAsync(
            int id,
            CancellationToken cancellation = default)
        {
            bool exists = await _personService.ExistsAsync(id, cancellation);
            return Ok(exists);
        }

        /// <summary>
        /// Check exists by national no
        /// HTTP: GET /api/People/exists/national-no/{nationalNo}
        /// </summary>
        [HttpGet("exists/national-no/{nationalNo}")]
        public async Task<IActionResult> CheckExistsByNationalNoAsync(
            string nationalNo,
            CancellationToken cancellation = default)
        {
            bool exists = await _personService.ExistsAsync(nationalNo, cancellation);
            return Ok(exists);
        }

        /// <summary>
        /// Deletes a person by ID.
        /// HTTP: DELETE /api/People/{id}
        /// </summary>
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(
            int id, 
            CancellationToken cancellation = default)
        {
            var result = await _personService.DeleteAsync(id, cancellation);

            if (!result.IsSuccess)
                return NotFound(result.Message);

            return NoContent();
        }
    }
}
