using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DVLD_Enterprise_System.Application.DTOs.Authentication
{
    /// <summary>
    /// Represents the credentials submitted by a client
    /// when attempting to authenticate a user account.
    ///
    /// The password is received only for verification.
    /// It must never be stored directly in the database.
    /// </summary>
    public class LoginRequestDto
    {
        /// <summary>
        /// Username used to identify the user account.
        /// </summary>
        [Required]
        [MaxLength(20)]
        public string UserName { get; set; } = string.Empty;

        /// <summary>
        /// Plain-text password supplied by the client.
        ///
        /// This value is used only during the authentication process
        /// and must never be persisted as plain text.
        /// </summary>
        [Required]
        public string Password { get; set; } = string.Empty;
    }
}
