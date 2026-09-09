using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Enterprise_System.Domain.Enums;

/// <summary>
/// Represents the gender of a person.
/// Maps to the [Gender] tinyint column on the People table.
///
/// WHY AN ENUM AND NOT JUST "byte"?
/// In the original database, the column comment says: "0 Male , 1 Femail , 2 Other".
/// If we kept the property as a raw byte, every developer reading the code (including
/// future-you) would have to memorize what 0, 1, and 2 mean, or go look it up.
/// An enum turns "magic numbers" into self-documenting, compiler-checked names.
/// EF Core can store this enum as its underlying numeric value automatically.
/// </summary>
public enum Gender : byte
{
    Male = 0,
    Female = 1,
    Other = 2
}
