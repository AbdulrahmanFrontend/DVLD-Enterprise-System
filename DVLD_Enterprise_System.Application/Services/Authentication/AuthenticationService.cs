using DVLD_Enterprise_System.Application.DTOs.Authentication;
using DVLD_Enterprise_System.Application.Interfaces;
using DVLD_Enterprise_System.Application.Security;
using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD_Enterprise_System.Application.Services.Authentication
{
    /// <summary>
    /// Provides application-level authentication logic.
    ///
    /// This service is responsible for:
    ///
    /// - Finding the user account.
    /// - Verifying the supplied password against the stored password hash.
    /// - Checking whether the account is active.
    /// - Returning authentication information to the API layer.
    ///
    /// It does not access the database directly.
    /// Database access is performed through IUserRepository.
    /// </summary>
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IUserRepository _userRepository;

        public AuthenticationService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        /// <summary>
        /// Attempts to authenticate a user using username and password.
        ///
        /// Authentication flow:
        ///
        /// 1. Find the user by username.
        /// 2. If the user does not exist, authentication fails.
        /// 3. Verify the supplied password against PasswordHash.
        /// 4. If the password is incorrect, authentication fails.
        /// 5. Check whether the account is active.
        /// 6. Return the authenticated user's basic information.
        ///
        /// JWT generation is intentionally not handled here yet.
        /// It will be introduced as a separate step.
        /// </summary>
        public async Task<LoginResponseDto?> LoginAsync(
            LoginRequestDto dto)
        {
            var user = await _userRepository
                .GetByUserNameAsync(dto.UserName);

            // Do not reveal whether the username exists.
            //
            // Returning null allows the API layer to return
            // HTTP 401 Unauthorized for invalid credentials.
            if (user == null)
                return null;

            // Password verification must be performed against
            // the stored hash.
            //
            // The plain-text password is never stored or compared
            // directly with the database value.
            var passwordValid = PasswordHasher.VerifyPassword(
                dto.Password,
                user.PasswordHash);

            if (!passwordValid)
                return null;

            // The credentials are correct, but the account is disabled.
            //
            // This is different from invalid credentials:
            // the user exists and authenticated successfully,
            // but the account is not currently allowed to log in.
            if (!user.IsActive)
            {
                throw new UnauthorizedAccessException(
                    "The user account is inactive.");
            }

            return new LoginResponseDto
            {
                UserID = user.UserID,
                UserName = user.UserName,
                IsActive = user.IsActive,
                PersonID = user.PersonID
            };
        }
    }
}
