using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Enterprise_System.Domain.Entities;

/// <summary>
/// Represents a system user (an employee who can log in to DVLD and perform actions).
/// Every User is linked 1-to-1 with a Person (a User IS a Person who also has login credentials).
/// </summary>
public class User
{
    public int UserID { get; set; }
    public int PersonID { get; set; }
    public string UserName { get; set; } = string.Empty;

    /// <summary>
    /// Stores a HASH of the password, never the plain text password.
    /// Hashing/verification logic belongs in the Application or Infrastructure layer
    /// (e.g. using ASP.NET Core Identity's PasswordHasher), not here in the Domain entity.
    /// </summary>
    public string PasswordHash { get; set; } = string.Empty;

    public bool IsActive { get; set; } = true;

    public Person Person { get; set; } = null!;
}
