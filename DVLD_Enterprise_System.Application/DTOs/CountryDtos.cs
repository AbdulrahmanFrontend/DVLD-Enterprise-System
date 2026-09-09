namespace DVLD_Enterprise_System.Application.DTOs;

/// <summary>
/// DTO (Data Transfer Object) returned to callers when reading a Country.
///
/// WHY NOT JUST RETURN THE Country ENTITY DIRECTLY FROM THE API?
/// 1) Decoupling: if you change the database/entity shape, your API contract
///    (what the frontend/consumers rely on) doesn't have to change automatically.
/// 2) Security: entities can carry sensitive or irrelevant fields (e.g. a
///    PasswordHash on User) that should never be serialized back to a client.
/// 3) Shape control: a DTO can combine/rename/omit fields exactly as the API
///    needs, independent of how the table is structured.
///
/// WHY A "record" INSTEAD OF A "class"?
/// C# records are a great fit for DTOs because they are immutable by default
/// (once created, the values can't change) and get free value-based equality
/// and a nice ToString() - perfect for simple "data bags" that just move data
/// from one layer to another.
/// </summary>
public record CountryDto(int CountryID, string CountryName);

/// <summary>DTO used when a client wants to create a new Country. No Id - the database generates it.</summary>
public record CountryCreateDto(string CountryName);
