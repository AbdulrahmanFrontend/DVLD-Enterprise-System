using DVLD_Enterprise_System.Infrastructure.Persistence;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DVLD_Enterprise_System.IntegrationTests.Factories
{
    public class CustomWebApplicationFactory<TProgram> : WebApplicationFactory<TProgram> where TProgram : class
    {
        // ⚠️ الحل الجذري: تثبيت اسم قاعدة البيانات في متغير ثابت لضمان عدم تغيره أبداً بين الـ Seeding والـ Controller
        public static readonly string DbName = "IntegrationTestDb_" + Guid.NewGuid();

        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {
                var descriptorsToRemove = services.Where(d =>
                    d.ServiceType == typeof(DVLDDbContext) ||
                    d.ServiceType == typeof(DbContextOptions<DVLDDbContext>) ||
                    d.ServiceType.FullName?.Contains("DbContextOptions") == true ||
                    d.ServiceType.FullName?.Contains("DVLDDbContext") == true
                ).ToList();

                foreach (var descriptor in descriptorsToRemove)
                {
                    services.Remove(descriptor);
                }

                services.AddDbContext<DVLDDbContext>(options =>
                {
                    options.UseInMemoryDatabase(DbName); // استخدام الاسم الثابت حصرياً
                });
            });
        }
    }
}