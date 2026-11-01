using DVLD_Enterprise_System.Application.DTOs.Users;
using DVLD_Enterprise_System.Domain.Entities;
using Mapster;

namespace DVLD_Enterprise_System.Application.Mappings;

public class UserMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<User, UserDto>()
            .Map(dest => dest.FullName, src => src.Person.FullName);

        config.NewConfig<User, FilteredUsersDto>()
            .Map(dest => dest.FullName, src => src.Person.FullName);
    }
}
