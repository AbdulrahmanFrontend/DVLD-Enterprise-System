using DevToolkit.Core.Results;
using DevToolkit.Data.Core;
using DVLD_Enterprise_System.Core.Models;
using System.Data;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevToolkit.Data;

namespace DVLD_Enterprise_System.DAL
{
    public static class CountryData
    {
        public static Result<CountryModel> GetByID(int id)
        {
            string Query = @"SELECT * FROM Countries WHERE CountryID = @CountryID;";

            DbParameterInfo[] Parameters = new DbParameterInfo[]
            {
                new DbParameterInfo
                {
                    Name = "@CountryID",
                    DbType = DbType.Int64,
                    Value = id
                }
            };

            return DataQueryService.FirstOrDefault<CountryModel>(
                CommandType.Text,
                Query,
                Parameters);
        }

        public static Result<DataTable> GetAll()
        {
            string Query = @"SELECT * FROM Countries;";

            return DbManager.Current?.GetDataTable(CommandType.Text, Query);
        }

        public static Result<bool> IsCountryExist(int id)
        {
            string Query = @"SELECT IsFound = 1 FROM Countries 
                WHERE CountryID = @CountryID;";

            DbParameterInfo[] Parameters = new DbParameterInfo[]
            {
                new DbParameterInfo
                {
                    Name = "@CountryID",
                    DbType = DbType.Int64,
                    Value = id,
                },
            };

            return DataQueryService.Scalar<bool>(CommandType.Text, Query, Parameters);
        }
    }
}
