using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD_Enterprise_System.Application.Interfaces
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync(
            CancellationToken cancellationToken = default);
    }
}
