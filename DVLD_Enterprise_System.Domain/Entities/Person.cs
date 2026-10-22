using DVLD_Enterprise_System.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_Enterprise_System.Domain.Entities;

/// <summary>
/// Represents a human being known to the system: could be an Applicant, a Driver,
/// or a User (employee), or several of these roles at once — that's why People is
/// a separate, central table that Users/Drivers/Applications all point back to.
/// </summary>
public class Person
{
    public int PersonID { get; set; }
    public string NationalNo { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string SecondName { get; set; } = string.Empty;

    /// <summary>Nullable because the DB column [ThirdName] allows NULL.</summary>
    public string? ThirdName { get; set; }

    public string LastName { get; set; } = string.Empty;
    public DateTime DateOfBirth { get; set; }
    public GenderType Gender { get; set; }
    public string Address { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;

    /// <summary>Nullable because the DB column [Email] allows NULL.</summary>
    public string? Email { get; set; }

    /// <summary>
    /// FOREIGN KEY PROPERTY (the raw int column, [NationalityCountryID]).
    /// Keeping both the FK id AND the navigation property below is the standard
    /// EF Core pattern - it lets you set a relationship either by id
    /// (person.NationalityCountryID = 5) or by object (person.NationalityCountry = someCountry).
    /// </summary>
    public int NationalityCountryID { get; set; }

    public string? ImagePath { get; set; }

    // ----- Navigation properties -----

    /// <summary>
    /// REFERENCE NAVIGATION PROPERTY ("many" side pointing to the "one").
    /// The "= null!" tells the compiler "trust me, EF Core will populate this
    /// when needed (via .Include()), don't warn me about nullability here."
    /// This is the standard convention for required relationships in EF Core 8/9/10 code.
    /// </summary>
    public Country NationalityCountry { get; set; } = null!;

    public ICollection<Application> Applications { get; set; } = new List<Application>();
}