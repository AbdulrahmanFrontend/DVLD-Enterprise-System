using DVLD_Enterprise_System.Application.DTOs.People;
using DVLD_Enterprise_System.Application.Services.People;
using Microsoft.AspNetCore.Mvc;

namespace DVLD_Enterprise_System.API.Controllers
{
    /// <summary>
    /// Handles HTTP requests related to people.
    ///
    /// The controller belongs to the API/presentation layer.
    /// Its responsibility is to:
    ///
    /// - Receive HTTP requests.
    /// - Read route/body parameters.
    /// - Call the appropriate application service.
    /// - Convert application results into HTTP responses.
    ///
    /// The controller should NOT:
    ///
    /// - Access EF Core directly.
    /// - Access DVLDDbContext directly.
    /// - Execute SQL queries.
    /// - Contain database logic.
    /// - Contain business/application rules.
    ///
    /// The actual application logic is handled by IPersonService.
    /// </summary>
    [Route("api/People")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        // The controller depends on the application abstraction
        // IPersonService instead of depending on the concrete
        // PersonService implementation.
        //
        // This is Dependency Injection.
        //
        // Program.cs registers:
        //
        // IPersonService → PersonService
        //
        // Therefore, ASP.NET Core's DI container automatically
        // creates PersonService and injects it here.
        private readonly IPersonService _personService;

        public PeopleController(IPersonService personService)
        {
            _personService = personService;
        }

        /// <summary>
        /// Returns all people.
        ///
        /// HTTP:
        /// GET /api/People
        ///
        /// Request flow:
        ///
        /// Client
        ///   ↓
        /// PeopleController.GetAll()
        ///   ↓
        /// IPersonService
        ///   ↓
        /// PersonService
        ///   ↓
        /// IPersonRepository
        ///   ↓
        /// PersonRepository
        ///   ↓
        /// DbContext
        ///   ↓
        /// SQL Server
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            // The controller delegates the operation to the
            // application/service layer.
            //
            // It does not know how people are stored or retrieved.
            var people = await _personService.GetAllAsync();

            // 200 OK + people serialized as JSON.
            return Ok(people);
        }

        /// <summary>
        /// Returns a specific person by ID.
        ///
        /// HTTP:
        /// GET /api/People/{id}
        ///
        /// Example:
        /// GET /api/People/10
        /// </summary>
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            // The {id:int} route constraint ensures that this
            // action is selected when the route value is an integer.
            //
            // Example:
            // /api/People/10 → matches
            // /api/People/abc → does not match this action.
            var person = await _personService.GetByIdAsync(id);

            // The service returns null when the person does not exist.
            //
            // The controller translates that application result
            // into the appropriate HTTP response.
            if (person == null)
                return NotFound();

            // 200 OK + person JSON.
            return Ok(person);
        }

        /// <summary>
        /// Creates a new person.
        ///
        /// HTTP:
        /// POST /api/People
        ///
        /// The request body contains CreatePersonDto as JSON.
        ///
        /// Example:
        ///
        /// {
        ///     "nationalNo": "N10",
        ///     "firstName": "Abdulrahman",
        ///     ...
        /// }
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> Create(CreatePersonDto dto)
        {
            // ASP.NET Core automatically binds the JSON request body
            // to CreatePersonDto because this is an API Controller.
            //
            // The controller then passes the DTO to the application layer.
            //
            // Validation/business rules and persistence are NOT
            // implemented here.
            var person = await _personService.CreateAsync(dto);

            // CreatedAtAction returns:
            //
            // HTTP 201 Created
            //
            // and provides the location of the newly created resource.
            //
            // nameof(GetById)
            //     → identifies the action that can retrieve the resource.
            //
            // new { id = person.PersonID }
            //     → generates the route values.
            //
            // person
            //     → returned as the response body.
            return CreatedAtAction(
                nameof(GetById),
                new { id = person.PersonID },
                person);
        }

        /// <summary>
        /// Updates an existing person.
        ///
        /// HTTP:
        /// PUT /api/People/{id}
        ///
        /// Example:
        /// PUT /api/People/10
        /// </summary>
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(
            int id,
            UpdatePersonDto dto)
        {
            // The ID comes from the route.
            //
            // The updated values come from the request body.
            //
            // Example:
            //
            // PUT /api/People/10
            //
            // id = 10
            // dto = updated person data
            var person = await _personService.UpdateAsync(id, dto);

            // If the service could not find the requested person,
            // return HTTP 404 Not Found.
            if (person == null)
                return NotFound();

            // 200 OK + updated person JSON.
            return Ok(person);
        }

        /// <summary>
        /// Deletes a person by ID.
        ///
        /// HTTP:
        /// DELETE /api/People/{id}
        ///
        /// Example:
        /// DELETE /api/People/10
        /// </summary>
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            // The controller delegates the deletion operation
            // to the application layer.
            //
            // It does not execute _context.People.Remove(...)
            // because database access belongs to Infrastructure.
            var deleted = await _personService.DeleteAsync(id);

            // The service returns false when the requested
            // person does not exist.
            if (!deleted)
                return NotFound();

            // HTTP 204 No Content means:
            //
            // The operation succeeded,
            // but there is no response body to return.
            return NoContent();
        }
    }
}