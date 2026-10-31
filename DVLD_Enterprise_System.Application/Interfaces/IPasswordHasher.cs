using DVLD_Enterprise_System.Domain.Entities;

namespace DVLD_Enterprise_System.Application.Interfaces;

public interface IPasswordHasher
{
    string HashPassword(User user, string password);
    bool VerifyPassword(User user, string hashedPassword, string providedPassword);
}
