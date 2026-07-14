using DevToolkit.Core.Results;
using DVLD_Enterprise_System.Core.Models;
using DVLD_Enterprise_System.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Enterprise_System.BLL
{
    public class CountryService
    {
        public CountryModel Model { get; set; }

        private CountryService(CountryModel model)
        {
            this.Model = model;
        }

        public static Result<CountryService> Find(int id)
        {
            var result = CountryData.GetByID(id);

            if (result.IsSuccess)
            {
                if (result.Data != null)
                    return Result<CountryService>
                        .Success(new CountryService(result.Data));

                return Result<CountryService>.Failure("Country not found!");
            }

            return Result<CountryService>.Failure("Failed to get this country!");
        }

        public static Result<DataTable> GetAll()
        {
            var result = CountryData.GetAll();

            if (result.IsSuccess)
            {
                if (result.Data != null)
                    return result;

                return Result<DataTable>.Failure("Countries not found!");
            }

            return Result<DataTable>.Failure("Failed to get all countries!");
        }
    }
}
