using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace DVLD_Enterprise_System.Application.Security
{
    /// <summary>
    /// Provides password hashing and verification functionality.
    ///
    /// Passwords are never stored as plain text.
    ///
    /// PBKDF2 is used to derive a secure password hash from
    /// the supplied password and a randomly generated salt.
    /// </summary>
    public static class PasswordHasher
    {
        private const int SaltSize = 16;
        private const int HashSize = 32;
        private const int Iterations = 100_000;

        /// <summary>
        /// Creates a secure password hash.
        ///
        /// A unique random salt is generated for every password.
        ///
        /// The returned value contains the information required
        /// to verify the password later.
        /// </summary>
        public static string HashPassword(string password)
        {
            ArgumentNullException.ThrowIfNull(password);

            byte[] salt = RandomNumberGenerator.GetBytes(SaltSize);

            byte[] hash = Rfc2898DeriveBytes.Pbkdf2(
                password,
                salt,
                Iterations,
                HashAlgorithmName.SHA256,
                HashSize);

            return $"{Iterations}.{Convert.ToBase64String(salt)}.{Convert.ToBase64String(hash)}";
        }

        /// <summary>
        /// Verifies a plain-text password against a previously generated hash.
        ///
        /// The stored hash contains the iteration count, salt, and derived hash.
        /// </summary>
        public static bool VerifyPassword(
            string password,
            string storedHash)
        {
            ArgumentNullException.ThrowIfNull(password);
            ArgumentNullException.ThrowIfNull(storedHash);

            var parts = storedHash.Split('.');

            if (parts.Length != 3)
                return false;

            if (!int.TryParse(parts[0], out int iterations))
                return false;

            byte[] salt;
            byte[] expectedHash;

            try
            {
                salt = Convert.FromBase64String(parts[1]);
                expectedHash = Convert.FromBase64String(parts[2]);
            }
            catch (FormatException)
            {
                return false;
            }

            byte[] actualHash = Rfc2898DeriveBytes.Pbkdf2(
                password,
                salt,
                iterations,
                HashAlgorithmName.SHA256,
                expectedHash.Length);

            return CryptographicOperations.FixedTimeEquals(
                actualHash,
                expectedHash);
        }
    }
}
