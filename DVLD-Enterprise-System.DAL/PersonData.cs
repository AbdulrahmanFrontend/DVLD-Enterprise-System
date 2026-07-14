using DevToolkit.Data.Core;
using DVLD_Enterprise_System.Core.Models;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevToolkit.Data;
using DevToolkit.Core.Results;
using DVLD_Enterprise_System.Core.Enums;
using DevToolkit.Logging.Managers;

namespace DVLD_Enterprise_System.DAL
{
    public static class PersonData
    {
        public static Result<PersonModel> GetByID(int id)
        {
            string Query = @"SELECT * FROM People WHERE PersonID = @PersonID;";

            DbParameterInfo[] Parameters = new DbParameterInfo[]
            {
                new DbParameterInfo
                {
                    Name = "@PersonID",
                    DbType = DbType.Int64,
                    Value = id
                }
            };

            return DataQueryService.FirstOrDefault<PersonModel>(
                CommandType.Text,
                Query, 
                Parameters);
        }

        public static Result<PersonModel> GetByNationalNo(string nationalNo)
        {
            string Query = @"SELECT * FROM People WHERE NationalNo = @NationalNo;";

            DbParameterInfo[] Parameters = new DbParameterInfo[]
            {
                new DbParameterInfo
                {
                    Name = "@NationalNo",
                    DbType = DbType.String,
                    Value = nationalNo
                }
            };

            return DataQueryService.FirstOrDefault<PersonModel>(
                CommandType.Text,
                Query,
                Parameters);
        }

        public static Result AddNew(PersonModel model)
        {
            string Query = @"INSERT INTO People 
            (
                NationalNo,
                FirstName,
                SecondName,
                ThirdName,
                LastName,
                DateOfBirth,
                Gender,
                Address,
                Phone,
                Email,
                NationalityCountryID,
                ImagePath
            )
            VALUES
            (
                @NationalNo,
                @FirstName,
                @SecondName,
                @ThirdName,
                @LastName,
                @DateOfBirth,
                @Gender,
                @Address,
                @Phone,
                @Email,
                @NationalityCountryID,
                @ImagePath
            );

            SELECT SCOPE_IDENTITY();";

            DbParameterInfo[] Parameters = new DbParameterInfo[]
            {
                new DbParameterInfo
                {
                    Name = "@NationalNo",
                    DbType = DbType.String,
                    Value = model.NationalNo,
                    Size = 20,
                },
                new DbParameterInfo
                {
                    Name = "@FirstName",
                    DbType = DbType.String,
                    Value = model.FirstName,
                    Size = 20,
                },
                new DbParameterInfo
                {
                    Name = "@SecondName",
                    DbType = DbType.String,
                    Value = model.SecondName,
                    Size = 20,
                },
                new DbParameterInfo
                {
                    Name = "@ThirdName",
                    DbType = DbType.String,
                    Value = model.ThirdName,
                    Size = 20,
                },
                new DbParameterInfo
                {
                    Name = "@LastName",
                    DbType = DbType.String,
                    Value = model.LastName,
                    Size = 20,
                },
                new DbParameterInfo
                {
                    Name = "@Gender",
                    DbType = DbType.Int16,
                    Value = model.Gender,
                },
                new DbParameterInfo
                {
                    Name = "@DateOfBirth",
                    DbType = DbType.DateTime,
                    Value = model.DateOfBirth,
                },
                new DbParameterInfo
                {
                    Name = "@Address",
                    DbType = DbType.String,
                    Value = model.Address,
                    Size = 500,
                },
                new DbParameterInfo
                {
                    Name = "@Phone",
                    DbType = DbType.String,
                    Value = model.Phone,
                    Size = 20,
                },
                new DbParameterInfo
                {
                    Name = "@Email",
                    DbType = DbType.String,
                    Value = model.Email,
                    Size = 50,
                },
                new DbParameterInfo
                {
                    Name = "@NationalityCountryID",
                    DbType = DbType.Int64,
                    Value = model.NationalityCountryID,
                },
                new DbParameterInfo
                {
                    Name = "@ImagePath",
                    DbType = DbType.String,
                    Value = model.ImagePath,
                    Size = 250,
                },
            };

            var result = DbManager.Current?.ExecuteNonQuery(
                CommandType.Text,
                Query, 
                Parameters);

            if (result.IsSuccess)
            {
                model.PersonID = result.Data;
                LogManager.LogInfo($"New Person with id {model.PersonID} " +
                    $"Saved Successfully.");
                return Result.Success($"New Person with id " +
                    $"{model.PersonID} Saved Successfully.");
            }

            return Result.Failure("Failed to add new person!");
        }

        public static Result Update(PersonModel model)
        {
            string Query = @"UPDATE People
                SET
                    NationalNo = @NationalNo, FirstName = @FirstName, 
                    SecondName = @SecondName, ThirdName = @ThirdName, 
                    LastName = @LastName, DateOfBirth = @DateOfBirth, Gender = @Gender,
                    Address = @Address, Phone = @Phone, Email = @Email, 
                    NationalityCountryID = @NationalityCountryID, ImagePath = @ImagePath
                WHERE PersonID = @PersonID;";

            DbParameterInfo[] Parameters = new DbParameterInfo[]
            {
                new DbParameterInfo
                {
                    Name = "@PersonID",
                    DbType = DbType.Int64,
                    Value = model.PersonID,
                },
                new DbParameterInfo
                {
                    Name = "@NationalNo",
                    DbType = DbType.String,
                    Value = model.NationalNo,
                    Size = 20,
                },
                new DbParameterInfo
                {
                    Name = "@FirstName",
                    DbType = DbType.String,
                    Value = model.FirstName,
                    Size = 20,
                },
                new DbParameterInfo
                {
                    Name = "@SecondName",
                    DbType = DbType.String,
                    Value = model.SecondName,
                    Size = 20,
                },
                new DbParameterInfo
                {
                    Name = "@ThirdName",
                    DbType = DbType.String,
                    Value = model.ThirdName,
                    Size = 20,
                },
                new DbParameterInfo
                {
                    Name = "@LastName",
                    DbType = DbType.String,
                    Value = model.LastName,
                    Size = 20,
                },
                new DbParameterInfo
                {
                    Name = "@Gender",
                    DbType = DbType.Int16,
                    Value = model.Gender,
                },
                new DbParameterInfo
                {
                    Name = "@DateOfBirth",
                    DbType = DbType.DateTime,
                    Value = model.DateOfBirth,
                },
                new DbParameterInfo
                {
                    Name = "@Address",
                    DbType = DbType.String,
                    Value = model.Address,
                    Size = 500,
                },
                new DbParameterInfo
                {
                    Name = "@Phone",
                    DbType = DbType.String,
                    Value = model.Phone,
                    Size = 20,
                },
                new DbParameterInfo
                {
                    Name = "@Email",
                    DbType = DbType.String,
                    Value = model.Email,
                    Size = 50,
                },
                new DbParameterInfo
                {
                    Name = "@NationalityCountryID",
                    DbType = DbType.Int64,
                    Value = model.NationalityCountryID,
                },
                new DbParameterInfo
                {
                    Name = "@ImagePath",
                    DbType = DbType.String,
                    Value = model.ImagePath,
                    Size = 250,
                },
            };

            var result = DbManager.Current?.ExecuteNonQuery(
                CommandType.Text,
                Query,
                Parameters);

            if (result.IsSuccess)
            {
                if (result.Data > 0)
                {
                    LogManager.LogInfo($"Person with id {model.PersonID} " +
                        $"Saved Successfully.");
                    return Result.Success($"Person with id " +
                        $"[{model.PersonID}] Saved Successfully.");
                }

                return Result.Failure("No People updated!");
            }

            return Result.Failure($"Failed to update person with id [{model.PersonID}]!");
        }

        public static Result<DataTable> GetPeople(
            int offset, 
            int pageSize,
            PeopleFilterMethods filterMethod,
            string filterValue)
        {
            string Query = string.Empty;

            DbParameterInfo Parameter = new DbParameterInfo
            {
                Name = "@FilterValue",
                DbType = DbType.String,
                Value = filterValue,
            };

            switch (filterMethod)
            {
                case PeopleFilterMethods.None:
                    Query = @"SELECT * FROM People
                        ORDER BY PersonID DESC
                        OFFSET @Offset ROWS
                        FETCH NEXT @PageSize ROWS ONLY;";
                    break;

                case PeopleFilterMethods.PersonID:
                    Query = @"SELECT * FROM People
                        WHERE PersonID = @FilterValue
                        ORDER BY PersonID DESC
                        OFFSET @Offset ROWS
                        FETCH NEXT @PageSize ROWS ONLY;";

                    Parameter = new DbParameterInfo
                    {
                        Name = "@FilterValue",
                        DbType = DbType.Int64,
                        Value = int.TryParse(filterValue?.ToString(),
                            out int value) ? value : 0,
                    };

                    break;

                case PeopleFilterMethods.NationalNo:
                    Query = @"SELECT * FROM People
                        WHERE NationalNo LIKE '%' || @FilterValue || '%'
                        ORDER BY PersonID DESC
                        OFFSET @Offset ROWS
                        FETCH NEXT @PageSize ROWS ONLY;";
                    break;

                case PeopleFilterMethods.FirstName:
                    Query = @"SELECT * FROM People
                        WHERE FirstName LIKE '%' || @FilterValue || '%'
                        ORDER BY PersonID DESC
                        OFFSET @Offset ROWS
                        FETCH NEXT @PageSize ROWS ONLY;";
                    break;

                case PeopleFilterMethods.SecondName:
                    Query = @"SELECT * FROM People
                        WHERE SecondName LIKE '%' || @FilterValue || '%'
                        ORDER BY PersonID DESC
                        OFFSET @Offset ROWS
                        FETCH NEXT @PageSize ROWS ONLY;";
                    break;

                case PeopleFilterMethods.ThirdName:
                    Query = @"SELECT * FROM People
                        WHERE ThirdName LIKE '%' || @FilterValue || '%'
                        ORDER BY PersonID DESC
                        OFFSET @Offset ROWS
                        FETCH NEXT @PageSize ROWS ONLY;";
                    break;

                case PeopleFilterMethods.LastName:
                    Query = @"SELECT * FROM People
                        WHERE LastName LIKE '%' || @FilterValue || '%'
                        ORDER BY PersonID DESC
                        OFFSET @Offset ROWS
                        FETCH NEXT @PageSize ROWS ONLY;";
                    break;

                case PeopleFilterMethods.DateOfBirth:
                    Query = @"SELECT * FROM People
                        WHERE DateOfBirth LIKE '%' || @FilterValue || '%'
                        ORDER BY PersonID DESC
                        OFFSET @Offset ROWS
                        FETCH NEXT @PageSize ROWS ONLY;";
                    break;

                case PeopleFilterMethods.Gender:
                    Query = @"SELECT * FROM People
                        WHERE Gender LIKE '%' || @FilterValue || '%'
                        ORDER BY PersonID DESC
                        OFFSET @Offset ROWS
                        FETCH NEXT @PageSize ROWS ONLY;";
                    break;

                case PeopleFilterMethods.Nationality:
                    //Query = @"SELECT * FROM People
                    //    WHERE Nationality LIKE '%' || @FilterValue || '%'
                    //    ORDER BY PersonID DESC
                    //    OFFSET @Offset ROWS
                    //    FETCH NEXT @PageSize ROWS ONLY;";
                    break;

                case PeopleFilterMethods.Phone:
                    Query = @"SELECT * FROM People
                        WHERE Phone LIKE '%' || @FilterValue || '%'
                        ORDER BY PersonID DESC
                        OFFSET @Offset ROWS
                        FETCH NEXT @PageSize ROWS ONLY;";
                    break;

                case PeopleFilterMethods.Email:
                    Query = @"SELECT * FROM People
                        WHERE Email LIKE '%' || @FilterValue || '%'
                        ORDER BY PersonID DESC
                        OFFSET @Offset ROWS
                        FETCH NEXT @PageSize ROWS ONLY;";
                    break;

                case PeopleFilterMethods.Address:
                    Query = @"SELECT * FROM People
                        WHERE Address LIKE '%' || @FilterValue || '%'
                        ORDER BY PersonID DESC
                        OFFSET @Offset ROWS
                        FETCH NEXT @PageSize ROWS ONLY;";
                    break;

                default:
                    Query = @"SELECT * FROM People
                        ORDER BY PersonID DESC
                        OFFSET @Offset ROWS
                        FETCH NEXT @PageSize ROWS ONLY;";
                    break;
            }

            List<DbParameterInfo> Parameters = new List<DbParameterInfo>
            {
                new DbParameterInfo
                {
                    Name = "@Offset",
                    DbType = DbType.Int64,
                    Value = offset,
                },
                new DbParameterInfo
                {
                    Name = "@PageSize",
                    DbType = DbType.UInt16,
                    Value = pageSize,
                }
            };

            Parameters.Add(Parameter);

            return DbManager.Current?.GetDataTable(CommandType.Text, Query, Parameters);
        }

        public static Result<int> GetPagesCount(
            PeopleFilterMethods filterMethod,
            string filterValue)
        {
            string Query = string.Empty;

            DbParameterInfo Parameter = new DbParameterInfo
            {
                Name = "@FilterValue",
                DbType = DbType.String,
                Value = filterValue,
            };

            switch (filterMethod)
            {
                case PeopleFilterMethods.None:
                    Query = @"SELECT COUNT(PersonID) FROM People;";
                    break;

                case PeopleFilterMethods.PersonID:
                    Query = @"SELECT COUNT(PersonID) FROM People
                        WHERE PersonID = @FilterValue
                        ORDER BY PersonID DESC;";

                    Parameter = new DbParameterInfo
                    {
                        Name = "@FilterValue",
                        DbType = DbType.Int64,
                        Value = int.TryParse(filterValue?.ToString(),
                            out int value) ? value : 0,
                    };

                    break;

                case PeopleFilterMethods.NationalNo:
                    Query = @"SELECT COUNT(PersonID) FROM People
                        WHERE NationalNo LIKE '%' || @FilterValue || '%'
                        ORDER BY PersonID DESC;";
                    break;

                case PeopleFilterMethods.FirstName:
                    Query = @"SELECT COUNT(PersonID) FROM People
                        WHERE FirstName LIKE '%' || @FilterValue || '%'
                        ORDER BY PersonID DESC;";
                    break;

                case PeopleFilterMethods.SecondName:
                    Query = @"SELECT COUNT(PersonID) FROM People
                        WHERE SecondName LIKE '%' || @FilterValue || '%'
                        ORDER BY PersonID DESC;";
                    break;

                case PeopleFilterMethods.ThirdName:
                    Query = @"SELECT COUNT(PersonID) FROM People
                        WHERE ThirdName LIKE '%' || @FilterValue || '%'
                        ORDER BY PersonID DESC;";
                    break;

                case PeopleFilterMethods.LastName:
                    Query = @"SELECT COUNT(PersonID) FROM People
                        WHERE LastName LIKE '%' || @FilterValue || '%'
                        ORDER BY PersonID DESC;";
                    break;

                case PeopleFilterMethods.DateOfBirth:
                    Query = @"SELECT COUNT(PersonID) FROM People
                        WHERE DateOfBirth LIKE '%' || @FilterValue || '%'
                        ORDER BY PersonID DESC;";
                    break;

                case PeopleFilterMethods.Gender:
                    Query = @"SELECT COUNT(PersonID) FROM People
                        WHERE Gender LIKE '%' || @FilterValue || '%'
                        ORDER BY PersonID DESC;";
                    break;

                case PeopleFilterMethods.Nationality:
                    //Query = @"SELECT COUNT(PersonID) FROM People
                    //    WHERE Nationality LIKE '%' || @FilterValue || '%'
                    //    ORDER BY PersonID DESC;";
                    break;

                case PeopleFilterMethods.Phone:
                    Query = @"SELECT COUNT(PersonID) FROM People
                        WHERE Phone LIKE '%' || @FilterValue || '%'
                        ORDER BY PersonID DESC;";
                    break;

                case PeopleFilterMethods.Email:
                    Query = @"SELECT COUNT(PersonID) FROM People
                        WHERE Email LIKE '%' || @FilterValue || '%'
                        ORDER BY PersonID DESC;";
                    break;

                case PeopleFilterMethods.Address:
                    Query = @"SELECT COUNT(PersonID) FROM People
                        WHERE Address LIKE '%' || @FilterValue || '%'
                        ORDER BY PersonID DESC;";
                    break;

                default:
                    Query = @"SELECT COUNT(PersonID) FROM People
                        ORDER BY PersonID DESC;";
                    break;
            }

            List<DbParameterInfo> Parameters = new List<DbParameterInfo>();

            Parameters.Add(Parameter);

            return DataQueryService.Scalar<int>(CommandType.Text, Query, Parameters);
        }

        public static Result Delete(int id)
        {
            string Query = @"DELETE People WHERE PersonID = @PersonID;";

            DbParameterInfo[] Parameters = new DbParameterInfo[]
            {
                new DbParameterInfo
                {
                    Name = "@PersonID",
                    DbType = DbType.Int64,
                    Value = id,
                },
            };

            var result = DbManager.Current?.ExecuteNonQuery(
                CommandType.Text,
                Query,
                Parameters);

            if (result.IsSuccess)
            {
                if (result.Data > 0)
                {
                    LogManager.LogInfo($"Person with id [{id}] deleted successfully.");
                    return Result.Success($"Person with id [{id}] deleted successfully.");
                }

                return Result.Failure($"No People deleted!");
            }

            return Result.Failure($"Failed to delete person with id [{id}]!");
        }

        public static Result<bool> IsPersonExist(int id)
        {
            string Query = @"SELECT IsFound = 1 FROM People WHERE PersonID = @PersonID;";

            DbParameterInfo[] Parameters = new DbParameterInfo[]
            {
                new DbParameterInfo
                {
                    Name = "@PersonID",
                    DbType = DbType.Int64,
                    Value = id,
                },
            };

            return DataQueryService.Scalar<bool>(CommandType.Text, Query, Parameters);
        }

        public static Result<bool> IsPersonExist(string nationalNo)
        {
            string Query = @"SELECT IsFound = 1 FROM People 
                WHERE NationalNo = @NationalNo;";

            DbParameterInfo[] Parameters = new DbParameterInfo[]
            {
                new DbParameterInfo
                {
                    Name = "@NationalNo",
                    DbType = DbType.String,
                    Value = nationalNo,
                },
            };

            return DataQueryService.Scalar<bool>(CommandType.Text, Query, Parameters);
        }

        public static Result<bool> IsPhoneExist(string phone, int id)
        {
            string Query = @"SELECT IsFound = 1 FROM People
                WHERE PersonID != @PersonID AND Phone = @Phone;";

            DbParameterInfo[] Parameters = new DbParameterInfo[]
            {
                new DbParameterInfo
                {
                    Name = "@PersonID",
                    DbType = DbType.Int64,
                    Value = id,
                },
                new DbParameterInfo
                {
                    Name = "@Phone",
                    DbType = DbType.String,
                    Value = phone,
                },
            };

            return DataQueryService.Scalar<bool>(CommandType.Text, Query, Parameters);
        }

        public static Result<bool> IsNationalNoExist(string nationalNo, int id)
        {
            string Query = @"SELECT IsFound = 1 FROM People
                WHERE PersonID != @PersonID AND NationalNo = @NationalNo;";

            DbParameterInfo[] Parameters = new DbParameterInfo[]
            {
                new DbParameterInfo
                {
                    Name = "@NationalNo",
                    DbType = DbType.Int64,
                    Value = id,
                },
                new DbParameterInfo
                {
                    Name = "@Phone",
                    DbType = DbType.String,
                    Value = nationalNo,
                },
            };

            return DataQueryService.Scalar<bool>(CommandType.Text, Query, Parameters);
        }
    }
}
