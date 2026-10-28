using DVLD_Enterprise_System.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DVLD_Enterprise_System.Infrastructure.Persistence.Seeding;

public static class DbSeeder
{
    public static async Task SeedAsync(DVLDDbContext context)
    {
        // ========================================================
        // 1. زرع الدول (Countries)
        // ========================================================
        if (!await context.Countries.AnyAsync())
        {
            context.Countries.AddRange(
                new Country { CountryName = "Afghanistan" },
                new Country { CountryName = "Albania" },
                new Country { CountryName = "Algeria" },
                new Country { CountryName = "Andorra" },
                new Country { CountryName = "Angola" },
                new Country { CountryName = "Antigua and Barbuda" },
                new Country { CountryName = "Argentina" },
                new Country { CountryName = "Armenia" },
                new Country { CountryName = "Austria" },
                new Country { CountryName = "Azerbaijan" },
                new Country { CountryName = "Bahrain" },
                new Country { CountryName = "Bangladesh" },
                new Country { CountryName = "Barbados" },
                new Country { CountryName = "Belarus" },
                new Country { CountryName = "Belgium" },
                new Country { CountryName = "Belize" },
                new Country { CountryName = "Benin" },
                new Country { CountryName = "Bhutan" },
                new Country { CountryName = "Bolivia" },
                new Country { CountryName = "Bosnia and Herzegovina" },
                new Country { CountryName = "Botswana" },
                new Country { CountryName = "Brazil" },
                new Country { CountryName = "Brunei" },
                new Country { CountryName = "Bulgaria" },
                new Country { CountryName = "Burkina Faso" },
                new Country { CountryName = "Burundi" },
                new Country { CountryName = "Cabo Verde" },
                new Country { CountryName = "Cambodia" },
                new Country { CountryName = "Cameroon" },
                new Country { CountryName = "Canada" },
                new Country { CountryName = "Central African Republic" },
                new Country { CountryName = "Chad" },
                new Country { CountryName = "Channel Islands" },
                new Country { CountryName = "Chile" },
                new Country { CountryName = "China" },
                new Country { CountryName = "Colombia" },
                new Country { CountryName = "Comoros" },
                new Country { CountryName = "Congo" },
                new Country { CountryName = "Costa Rica" },
                new Country { CountryName = "Côte d'Ivoire" },
                new Country { CountryName = "Croatia" },
                new Country { CountryName = "Cuba" },
                new Country { CountryName = "Cyprus" },
                new Country { CountryName = "Czech Republic" },
                new Country { CountryName = "Denmark" },
                new Country { CountryName = "Djibouti" },
                new Country { CountryName = "Dominica" },
                new Country { CountryName = "Dominican Republic" },
                new Country { CountryName = "DR Congo" },
                new Country { CountryName = "Ecuador" },
                new Country { CountryName = "Egypt" },
                new Country { CountryName = "El Salvador" },
                new Country { CountryName = "Equatorial Guinea" },
                new Country { CountryName = "Eritrea" },
                new Country { CountryName = "Estonia" },
                new Country { CountryName = "Eswatini" },
                new Country { CountryName = "Ethiopia" },
                new Country { CountryName = "Faeroe Islands" },
                new Country { CountryName = "Finland" },
                new Country { CountryName = "France" },
                new Country { CountryName = "French Guiana" },
                new Country { CountryName = "Gabon" },
                new Country { CountryName = "Gambia" },
                new Country { CountryName = "Georgia" },
                new Country { CountryName = "Germany" },
                new Country { CountryName = "Ghana" },
                new Country { CountryName = "Gibraltar" },
                new Country { CountryName = "Greece" },
                new Country { CountryName = "Grenada" },
                new Country { CountryName = "Guatemala" },
                new Country { CountryName = "Guinea" },
                new Country { CountryName = "Guinea-Bissau" },
                new Country { CountryName = "Guyana" },
                new Country { CountryName = "Haiti" },
                new Country { CountryName = "Holy See" },
                new Country { CountryName = "Honduras" },
                new Country { CountryName = "Hong Kong" },
                new Country { CountryName = "Hungary" },
                new Country { CountryName = "Iceland" },
                new Country { CountryName = "India" },
                new Country { CountryName = "Indonesia" },
                new Country { CountryName = "Iran" },
                new Country { CountryName = "Iraq" },
                new Country { CountryName = "Ireland" },
                new Country { CountryName = "Isle of Man" },
                new Country { CountryName = "Israel" },
                new Country { CountryName = "Italy" },
                new Country { CountryName = "Jamaica" },
                new Country { CountryName = "Japan" },
                new Country { CountryName = "Jordan" },
                new Country { CountryName = "Kazakhstan" },
                new Country { CountryName = "Kenya" },
                new Country { CountryName = "Kuwait" },
                new Country { CountryName = "Kyrgyzstan" },
                new Country { CountryName = "Laos" },
                new Country { CountryName = "Latvia" },
                new Country { CountryName = "Lebanon" },
                new Country { CountryName = "Lesotho" },
                new Country { CountryName = "Liberia" },
                new Country { CountryName = "Libya" },
                new Country { CountryName = "Liechtenstein" },
                new Country { CountryName = "Lithuania" },
                new Country { CountryName = "Luxembourg" },
                new Country { CountryName = "Macao" },
                new Country { CountryName = "Madagascar" },
                new Country { CountryName = "Malawi" },
                new Country { CountryName = "Malaysia" },
                new Country { CountryName = "Maldives" },
                new Country { CountryName = "Mali" },
                new Country { CountryName = "Malta" },
                new Country { CountryName = "Mauritania" },
                new Country { CountryName = "Mauritius" },
                new Country { CountryName = "Mayotte" },
                new Country { CountryName = "Mexico" },
                new Country { CountryName = "Moldova" },
                new Country { CountryName = "Monaco" },
                new Country { CountryName = "Mongolia" },
                new Country { CountryName = "Montenegro" },
                new Country { CountryName = "Morocco" },
                new Country { CountryName = "Mozambique" },
                new Country { CountryName = "Myanmar" },
                new Country { CountryName = "Namibia" },
                new Country { CountryName = "Nepal" },
                new Country { CountryName = "Netherlands" },
                new Country { CountryName = "Nicaragua" },
                new Country { CountryName = "Niger" },
                new Country { CountryName = "Nigeria" },
                new Country { CountryName = "North Korea" },
                new Country { CountryName = "North Macedonia" },
                new Country { CountryName = "Norway" },
                new Country { CountryName = "Oman" },
                new Country { CountryName = "Pakistan" },
                new Country { CountryName = "Panama" },
                new Country { CountryName = "Paraguay" },
                new Country { CountryName = "Peru" },
                new Country { CountryName = "Philippines" },
                new Country { CountryName = "Poland" },
                new Country { CountryName = "Portugal" },
                new Country { CountryName = "Qatar" },
                new Country { CountryName = "Réunion" },
                new Country { CountryName = "Romania" },
                new Country { CountryName = "Russia" },
                new Country { CountryName = "Rwanda" },
                new Country { CountryName = "Saint Helena" },
                new Country { CountryName = "Saint Kitts and Nevis" },
                new Country { CountryName = "Saint Lucia" },
                new Country { CountryName = "Saint Vincent and the Grenadines" },
                new Country { CountryName = "San Marino" },
                new Country { CountryName = "Sao Tome & Principe" },
                new Country { CountryName = "Saudi Arabia" },
                new Country { CountryName = "Senegal" },
                new Country { CountryName = "Serbia" },
                new Country { CountryName = "Seychelles" },
                new Country { CountryName = "Sierra Leone" },
                new Country { CountryName = "Singapore" },
                new Country { CountryName = "Slovakia" },
                new Country { CountryName = "Slovenia" },
                new Country { CountryName = "Somalia" },
                new Country { CountryName = "South Africa" },
                new Country { CountryName = "South Korea" },
                new Country { CountryName = "South Sudan" },
                new Country { CountryName = "Spain" },
                new Country { CountryName = "Sri Lanka" },
                new Country { CountryName = "State of Palestine" },
                new Country { CountryName = "Sudan" },
                new Country { CountryName = "Suriname" },
                new Country { CountryName = "Sweden" },
                new Country { CountryName = "Switzerland" },
                new Country { CountryName = "Syria" },
                new Country { CountryName = "Taiwan" },
                new Country { CountryName = "Tajikistan" },
                new Country { CountryName = "Tanzania" },
                new Country { CountryName = "Thailand" },
                new Country { CountryName = "The Bahamas" },
                new Country { CountryName = "Timor-Leste" },
                new Country { CountryName = "Togo" },
                new Country { CountryName = "Trinidad and Tobago" },
                new Country { CountryName = "Tunisia" },
                new Country { CountryName = "Turkey" },
                new Country { CountryName = "Turkmenistan" },
                new Country { CountryName = "Uganda" },
                new Country { CountryName = "Ukraine" },
                new Country { CountryName = "United Arab Emirates" },
                new Country { CountryName = "United Kingdom" },
                new Country { CountryName = "United States" },
                new Country { CountryName = "Uruguay" },
                new Country { CountryName = "Uzbekistan" },
                new Country { CountryName = "Venezuela" },
                new Country { CountryName = "Vietnam" },
                new Country { CountryName = "Western Sahara" },
                new Country { CountryName = "Yemen" },
                new Country { CountryName = "Zambia" },
                new Country { CountryName = "Zimbabwe" }
            );
            await context.SaveChangesAsync();
        }

        // ========================================================
        // 2. زرع أنواع الطلبات (ApplicationTypes)[cite: 15]
        // ========================================================
        /*
        if (!await context.ApplicationTypes.AnyAsync())
        {
            // استبدل أسماء الخصائص (Title, Fees) بما ستقوم بتسميته في الكيان لديك
            
            context.ApplicationTypes.AddRange(
                new ApplicationType { Title = "New Local Driving License Service", Fees = 15 },
                new ApplicationType { Title = "Renew Driving License Service", Fees = 5 },
                new ApplicationType { Title = "Replacement for a Lost Driving License", Fees = 10 },
                new ApplicationType { Title = "Replacement for a Damaged Driving License", Fees = 5 },
                new ApplicationType { Title = "Release Detained Driving Licsense", Fees = 15 },
                new ApplicationType { Title = "New International License", Fees = 50 },
                new ApplicationType { Title = "Retake Test", Fees = 5 }
            );
            await context.SaveChangesAsync();
            
        }
            */

        // ========================================================
        // 3. زرع أنواع الاختبارات (TestTypes)[cite: 18]
        // ========================================================
        /*
        if (!await context.TestTypes.AnyAsync())
        {

            context.TestTypes.AddRange(
                new TestType 
                { 
                    Title = "Vision Test", 
                    Description = "This assesses the applicant's visual acuity to ensure they have sufficient vision to drive safely.", 
                    Fees = 10 
                },
                new TestType 
                { 
                    Title = "Written (Theory) Test", 
                    Description = "This test assesses the applicant's knowledge of traffic rules, road signs, and driving regulations. It typically consists of multiple-choice questions, and the applicant must select the correct answer(s). The written test aims to ensure that the applicant understands the rules of the road and can apply them in various driving scenarios.", 
                    Fees = 20 
                },
                new TestType 
                { 
                    Title = "Practical (Street) Test", 
                    Description = "This test evaluates the applicant's driving skills and ability to operate a motor vehicle safely on public roads. A licensed examiner accompanies the applicant in the vehicle and observes their driving performance.", 
                    Fees = 30 
                }
            );
            await context.SaveChangesAsync();

        }
            */

        // ========================================================
        // 4. زرع أصناف الرخص (ClassLicenses)[cite: 17]
        // ========================================================
        /*
        if (!await context.ClassLicenses.AnyAsync())
        {
            context.ClassLicenses.AddRange(
                new ClassLicense 
                { 
                    ClassName = "Class 1 - Small Motorcycle", 
                    ClassDescription = "It allows the driver to drive small motorcycles, It is suitable for motorcycles with small capacity and limited power.", 
                    MinimumAllowedAge = 18, 
                    DefaultValidityLength = 5, 
                    ClassFees = 15 
                },
                new ClassLicense 
                { 
                    ClassName = "Class 2 - Heavy Motorcycle License", 
                    ClassDescription = "Heavy Motorcycle License (Large Motorcycle License)", 
                    MinimumAllowedAge = 21, 
                    DefaultValidityLength = 5, 
                    ClassFees = 30 
                },
                new ClassLicense 
                { 
                    ClassName = "Class 3 - Ordinary driving license", 
                    ClassDescription = "Ordinary driving license (car licence)", 
                    MinimumAllowedAge = 18, 
                    DefaultValidityLength = 10, 
                    ClassFees = 20 
                },
                new ClassLicense 
                { 
                    ClassName = "Class 4 - Commercial", 
                    ClassDescription = "Commercial driving license (taxi/limousine)", 
                    MinimumAllowedAge = 21, 
                    DefaultValidityLength = 10, 
                    ClassFees = 200 
                },
                new ClassLicense 
                { 
                    ClassName = "Class 5 - Agricultural", 
                    ClassDescription = "Agricultural and work vehicles work vehicles used in farming or construction, (tractors / tillage machinery)", 
                    MinimumAllowedAge = 21, 
                    DefaultValidityLength = 10, 
                    ClassFees = 50 
                },
                new ClassLicense 
                { 
                    ClassName = "Class 6 - Small and medium bus", 
                    ClassDescription = "Small and medium bus license", 
                    MinimumAllowedAge = 21, 
                    DefaultValidityLength = 10, 
                    ClassFees = 250 
                },
                new ClassLicense 
                { 
                    ClassName = "Class 7 - Truck and heavy vehicle", 
                    ClassDescription = "Truck and heavy vehicle license", 
                    MinimumAllowedAge = 21, 
                    DefaultValidityLength = 10, 
                    ClassFees = 300 
                }
            );
            await context.SaveChangesAsync();

        }
            */
    }
}
