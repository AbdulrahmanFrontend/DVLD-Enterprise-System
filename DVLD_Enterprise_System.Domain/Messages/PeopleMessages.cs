using DVLD_Enterprise_System.Domain.Constants.FieldsNames;
using DVLD_Enterprise_System.Domain.Constants.PropertiesMaxLength;

namespace DVLD_Enterprise_System.Domain.Messages;

public static class PeopleMessages
{
    public static string RequiredNationalNo => 
        GeneralMessages.Required(PeopleFieldsNames.NationalNoName);
    public static string NationalNoMaxLength
    {
        get => GeneralMessages.MaxLength(
                    PeopleFieldsNames.NationalNoName,
                    PeopleFieldsMaxLength.NationalNoMaxLength);
    }
    public static  string InvalidNationalNo => 
        GeneralMessages.Invalid(PeopleFieldsNames.NationalNoName);
    public static string ExistsNationalNo => 
        GeneralMessages.AlreadyExists(PeopleFieldsNames.NationalNoName);

    public static string RequiredFirstName => 
        GeneralMessages.Required(PeopleFieldsNames.FirstName);
    public static string FirstNameMaxLength 
    {
        get => GeneralMessages.MaxLength(
                    PeopleFieldsNames.FirstName,
                    PeopleFieldsMaxLength.FirstNameMaxLength);
    }

    public static string RequiredSecondName => 
        GeneralMessages.Required(PeopleFieldsNames.SecondName);
    public static string SecondNameMaxLength
    {
        get => GeneralMessages.MaxLength(
                    PeopleFieldsNames.SecondName, 
                    PeopleFieldsMaxLength.SecondNameMaxLength);
    }

    public static string ThirdNameMaxLength
    {
        get => GeneralMessages.MaxLength(
                    PeopleFieldsNames.ThirdName, 
                    PeopleFieldsMaxLength.ThirdNameMaxLength);
    }

    public static string RequiredLastName => 
        GeneralMessages.Required(PeopleFieldsNames.LastName);
    public static string LastNameMaxLength 
    {
        get => GeneralMessages.MaxLength(
                    PeopleFieldsNames.LastName, 
                    PeopleFieldsMaxLength.LastNameMaxLength);
    }

    public static string RequirdPhone => 
        GeneralMessages.Required(PeopleFieldsNames.PhoneNumberName);
    public static string PhoneMaxLength
    {
        get => GeneralMessages.MaxLength(
                    PeopleFieldsNames.PhoneNumberName, 
                    PeopleFieldsMaxLength.PhoneNumberMaxLength);
    }
    public static string InvalidPhone => 
        GeneralMessages.Invalid(PeopleFieldsNames.PhoneNumberName);
    public static string ExistsPhone => 
        GeneralMessages.AlreadyExists(PeopleFieldsNames.PhoneNumberName);

    public static string EmailMaxLength
    {
        get => GeneralMessages.MaxLength(
                    PeopleFieldsNames.EmailName,
                    PeopleFieldsMaxLength.EmailMaxLength);
    }
    public static string InvalidEmail => 
        GeneralMessages.Invalid(PeopleFieldsNames.EmailName);
    public static string ExistsEmail =>
        GeneralMessages.AlreadyExists(PeopleFieldsNames.EmailName);

    public static string InvalidGender => 
        GeneralMessages.Invalid(PeopleFieldsNames.GenderTypeName);

    public static string InvalidNationality =>
        GeneralMessages.Invalid(PeopleFieldsNames.NationalityName);

    public static string InvalidDateOfBirth => 
        GeneralMessages.Invalid(PeopleFieldsNames.DateOfBirthName);

    public static string ImagePathMaxLength
    {
        get => GeneralMessages.MaxLength(
                    PeopleFieldsNames.ImagePathName,
                    PeopleFieldsMaxLength.ImagePathMaxLength);
    }
    public static string InvalidImagePath => 
        GeneralMessages.Invalid(PeopleFieldsNames.ImagePathName);

    public static string RequiredAddress =>
        GeneralMessages.Required(PeopleFieldsNames.AddressName);
    public static string AddressMaxLength
    {
        get => GeneralMessages.MaxLength(
                    PeopleFieldsNames.AddressName, 
                    PeopleFieldsMaxLength.AddressMaxLength);
    }
}
