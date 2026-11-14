using DVLD_Enterprise_System.Application.Common;
using DVLD_Enterprise_System.Application.DTOs.People;

namespace DVLD_Enterprise_System.Application.Interfaces
{
    public interface IPersonService
    {
        Task<PagedResult<FilteredPeopleDto>> GetFilteredPeopleAsync(
            GetPeopleQueryDto queryDto,
            CancellationToken cancellation = default);

        Task<PersonDto?> GetByIdAsync(int id, CancellationToken cancellation = default);

        Task<PersonDto?> GetByNationalNoAsync(
            string nationalNo,
            CancellationToken cancellation = default);

        Task<PersonDto?> GetByPhoneNumberAsync(
            string phoneNumber,
            CancellationToken cancellation = default);

        Task<PersonDto?> GetByEmailAsync(
            string email,
            CancellationToken cancellation = default);

        Task<bool> ExistsAsync(int id, CancellationToken cancellation = default);

        Task<bool> ExistsAsync(string nationalNo, CancellationToken cancellation = default);

        Task<int> CreateAsync(
            CreatePersonDto dto, 
            CancellationToken cancellation = default);

        Task UpdateAsync(
            int id,
            UpdatePersonDto dto,
            CancellationToken cancellation = default);

        Task DeleteAsync(int id, CancellationToken cancellation = default);
    }
}
