using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Enterprise_System.Domain.Entities
{
    /// <summary>
    /// Represents a system user account.
    ///
    /// A User account is associated with exactly one Person.
    /// The database enforces this relationship through:
    ///
    /// - Users.PersonID → People.PersonID foreign key.
    /// - UQ_PersonID → ensures one User per Person.
    ///
    /// The entity represents domain data only.
    /// It does not contain authentication logic or database code.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Unique identifier of the user account.
        /// </summary>
        public int UserID { get; set; }

        /// <summary>
        /// Foreign key referencing the Person associated
        /// with this user account.
        /// </summary>
        public int PersonID { get; set; }

        /// <summary>
        /// Unique username used to identify the account during login.
        /// </summary>
        public string UserName { get; set; } = string.Empty;

        /// <summary>
        /// Stores the hashed password.
        ///
        /// The plain-text password must never be stored in the database.
        /// </summary>
        public string PasswordHash { get; set; } = string.Empty;

        /// <summary>
        /// Determines whether the account is currently allowed to log in.
        ///
        /// false means the account is disabled.
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Navigation property to the Person associated with this account.
        ///
        /// This represents the relationship:
        ///
        /// User → Person
        /// </summary>
        public Person? Person { get; set; }
    }
}
