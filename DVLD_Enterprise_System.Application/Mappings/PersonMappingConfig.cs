using DVLD_Enterprise_System.Application.DTOs.People;
using DVLD_Enterprise_System.Domain.Entities;
using Mapster;

namespace DVLD_Enterprise_System.Application.Mappings;

public class PersonMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        // إخبار Mapster كيف يربط Entity مع الـ DTO الخاص بها
        config.NewConfig<Person, FilteredPeopleDto>()
            .Map(dest => dest.NationalityCountryName,
                 src => src.NationalityCountry != null ? 
                 src.NationalityCountry.CountryName : string.Empty);

        // ملاحظة: باقي الخصائص المتطابقة في الأسماء سيتم ربطها تلقائياً (Convention-based)
    }
}
