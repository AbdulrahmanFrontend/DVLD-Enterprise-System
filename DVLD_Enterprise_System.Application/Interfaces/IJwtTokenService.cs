using DVLD_Enterprise_System.Domain.Entities;

namespace DVLD_Enterprise_System.Application.Interfaces;

public interface IJwtTokenService
{
    string GenerateToken(User user);
}
