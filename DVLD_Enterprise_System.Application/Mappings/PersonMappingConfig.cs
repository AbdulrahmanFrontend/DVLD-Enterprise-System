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

        // 2. ربط CreatePersonDto مع الكيان Person (تتطابق الأسماء تلقائياً، وImagePath يتم تعيينه يدوياً في الـ Service)
        config.NewConfig<CreatePersonDto, Person>()
            .Ignore(dest => dest.PersonID)
            .Ignore(dest => dest.ImagePath); // يتم تعيين مسار الصورة برمجياً بعد حفظها عبر IFileStorageService

        // 3. ربط UpdatePersonDto مع الكيان Person
        config.NewConfig<UpdatePersonDto, Person>()
            .Ignore(dest => dest.ImagePath); // يتم تحديثه يدوياً في الـ Service مع مراعاة الحفاظ على القديم أو الجديد
    }
}
