using DVLD_Enterprise_System.Application.DTOs.Authentication;
using DVLD_Enterprise_System.Application.Services.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DVLD_Enterprise_System.API.Controllers
{
    /// <summary>
    /// Handles HTTP requests related to user authentication.
    ///
    /// The controller is responsible only for HTTP-level concerns.
    /// Authentication logic is delegated to IAuthenticationService.
    /// </summary>
    [Route("api/Auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;

        public AuthController(
            IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        /// <summary>
        /// Authenticates a user using username and password.
        ///
        /// HTTP:
        /// POST /api/Auth/Login
        ///
        /// Returns:
        /// 200 OK when authentication succeeds.
        /// 401 Unauthorized when the credentials are invalid.
        /// </summary>
        [HttpPost("Login")]
        public async Task<IActionResult> Login(
            LoginRequestDto dto)
        {
            var result = await _authenticationService.LoginAsync(dto);

            if (result == null)
                return Unauthorized();

            return Ok(result);
        }
    }
}
