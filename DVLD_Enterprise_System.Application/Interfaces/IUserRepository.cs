using DVLD_Enterprise_System.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD_Enterprise_System.Application.Interfaces
{
    public interface IUserRepository
    {
        Task<User?> GetByUserIdAsync(int id);

        Task<User?> GetByPersonIdAsync(int personId);
    }
}
