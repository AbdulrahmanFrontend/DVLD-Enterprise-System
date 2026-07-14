using DevToolkit.Core;
using DevToolkit.Core.Results;
using DevToolkit.Core.Validation;
using DVLD_Enterprise_System.Core.Enums;
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
    public class PersonService : BaseBusiness
    {
        public PersonModel Model { get; private set; }

        public CountryModel Country { get; private set; }

        public PersonService()
        {
            Model = new PersonModel();
            Country = new CountryModel();
        }

        public PersonService(PersonModel model)
        {
            this.Model = model;

            Result<CountryModel> result = 
                CountryData.GetByID(model.NationalityCountryID);

            if (result.IsSuccess && result.Data != null)
                Country = result.Data;
            else
                Country = new CountryModel();
        }

        public static Result<PersonService> Find(int id)
        {
            var result = PersonData.GetByID(id);

            if (result.IsSuccess)
            {
                if (result.Data != null)
                    return Result<PersonService>.Success(new PersonService(result.Data));

                return Result<PersonService>.Failure($"Person with id [{id}] not found!");
            }

            return Result<PersonService>.Failure($"Failed to get person with id [{id}]!");
        }

        public static Result<PersonService> Find(string nationalNo)
        {
            var result = PersonData.GetByNationalNo(nationalNo);

            if (result.IsSuccess)
            {
                if (result.Data != null)
                    return Result<PersonService>.Success(new PersonService(result.Data));

                return Result<PersonService>.Failure(
                    $"Person with national no [{nationalNo}] not found!");
            }

            return Result<PersonService>.Failure(
                $"Failed to get person with national no [{nationalNo}]!");
        }

        public Result ValidateNationalNo()
        {
            Result ValResult = _ValidateProperty(this.Model.NationalNo, this.Model);

            if (!ValResult.IsSuccess)
                return ValResult;

            var result = PersonData.IsNationalNoExist(
                this.Model.NationalNo, 
                this.Model.PersonID);

            if (result.IsSuccess)
            {
                if (result.Data)
                    return Result.Failure("This National Number already exists!");

                return Result.Success();
            }

            return Result.Failure(
                "Failed to check if the national number already exists");
        }

        public Result ValidateFirstName()
            => _ValidateProperty(this.Model.FirstName, this.Model);

        public Result ValidateSecondName()
            => _ValidateProperty(this.Model.SecondName, this.Model);

        public Result ValidateThirdName()
            => _ValidateProperty(this.Model.ThirdName, this.Model);

        public Result ValidateLastName()
            => _ValidateProperty(this.Model.LastName, this.Model);

        public Result ValidateAddress()
            => _ValidateProperty(this.Model.Address, this.Model);

        public Result ValidatePhone()
        {
            Result ValResult = _ValidateProperty(this.Model.Phone, this.Model);

            if (!ValResult.IsSuccess)
                return ValResult;

            var result = PersonData.IsPhoneExist(
                this.Model.Phone,
                this.Model.PersonID);

            if (result.IsSuccess)
            {
                if (result.Data)
                    return Result.Failure("This Phone Number already exists!");

                return Result.Success();
            }

            return Result.Failure(
                "Failed to check if the phone number already exists");
        }

        public Result ValidateEmail()
            => _ValidateProperty(this.Model.Email, this.Model);

        public Result ValidateNationalityCountryID()
        {
            var result = CountryData.IsCountryExist(this.Model.NationalityCountryID);

            if (result.IsSuccess)
            {
                if (result.Data)
                    return Result.Success();

                return Result.Failure("Country not found!");
            }

            return Result.Failure("Failed to check if this country found!");
        }

        protected override ValidationResult _Validate()
            => ObjectValidator.ValidateObject<PersonModel>(this.Model);

        public override Result Valid()
        {
            var result = ValidateNationalNo();

            if (!result.IsSuccess)
                return result;

            result = ValidateFirstName();

            if (!result.IsSuccess)
                return result;

            result = ValidateSecondName();

            if (!result.IsSuccess)
                return result;

            result = ValidateThirdName();

            if (!result.IsSuccess)
                return result;

            result = ValidateLastName();

            if (!result.IsSuccess)
                return result;

            result = ValidateNationalityCountryID();

            if (!result.IsSuccess)
                return result;

            result = ValidatePhone();

            if (!result.IsSuccess)
                return result;

            result = ValidateEmail();

            if (!result.IsSuccess)
                return result;

            result = ValidateAddress();

            if (!result.IsSuccess)
                return result;

            return Result.Success();
        }

        protected override Result _AddNew()
        {
            var result = Valid();

            if(!result.IsSuccess)
                return result;

            return PersonData.AddNew(this.Model);
        }

        protected override Result _Update()
        {
            var result = Valid();

            if (!result.IsSuccess)
                return result;

            return PersonData.Update(this.Model);
        }

        public static Result<DataTable> GetPeople(
            int currentPage,
            int pageSize,
            PeopleFilterMethods filterMethod,
            string filterValue)
        {
            int Offset = (currentPage - 1) * pageSize;

            var result = PersonData.GetPeople(
                Offset,
                pageSize, 
                filterMethod, 
                filterValue);

            if (result.IsSuccess)
                return result;

            return Result<DataTable>.Failure("Failed to get people!");
        }

        public static Result Delete(int id) => PersonData.Delete(id);

        public static Result IsPersonExist(int id)
        {
            var result = PersonData.IsPersonExist(id);

            if (result.IsSuccess)
            {
                if (result.Data)
                    return Result.Success();

                return Result.Failure($"Person with id [{id}] not found!");
            }

            return Result.Failure($"Failed to check if person with id [{id}] found!");
        }

        public static Result IsPersonExist(string nationalNo)
        {
            var result = PersonData.IsPersonExist(nationalNo);

            if (result.IsSuccess)
            {
                if (result.Data)
                    return Result.Success();

                return Result.Failure(
                    $"Person with national no [{nationalNo}] not found!");
            }

            return Result.Failure(
                $"Failed to check if person with national no [{nationalNo}] found!");
        }
    }
}
