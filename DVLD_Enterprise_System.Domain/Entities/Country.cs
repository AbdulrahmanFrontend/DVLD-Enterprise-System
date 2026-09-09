using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Enterprise_System.Domain.Entities;

/// <summary>
/// A reference/lookup table of countries. Used mainly for a Person's nationality.
/// </summary>
public class Country
{
    public int CountryID { get; set; }
    public string CountryName { get; set; } = string.Empty;

    /// <summary>
    /// COLLECTION NAVIGATION PROPERTY ("one" side of a one-to-many relationship).
    /// One Country can be the nationality of many People.
    /// We initialize it to an empty list (instead of leaving it null) so that
    /// code like "country.People.Add(...)" never throws a NullReferenceException
    /// even before EF Core has loaded any related people.
    /// </summary>
    public ICollection<Person> People { get; set; } = new List<Person>();
}

