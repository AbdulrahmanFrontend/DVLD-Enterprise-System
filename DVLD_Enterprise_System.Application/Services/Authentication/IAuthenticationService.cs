using DVLD_Enterprise_System.Application.DTOs.Authentication;
using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD_Enterprise_System.Application.Services.Authentication
{
    /// <summary>
    /// Defines the application operations related to user authentication.
    ///
    /// The interface belongs to the Application layer and describes
    /// what the application can do without depending on any specific
    /// authentication or data-access implementation.
    /// </summary>
    public interface IAuthenticationService
    {
        /// <summary>
        /// Attempts to authenticate a user using the supplied credentials.
        ///
        /// Returns a LoginResponseDto when authentication succeeds.
        /// Returns null when the supplied username or password is invalid.
        ///
        /// Throws UnauthorizedAccessException when the credentials are valid
        /// but the user account is inactive.
        /// </summary>
        Task<LoginResponseDto?> LoginAsync(LoginRequestDto dto);
    }
}
