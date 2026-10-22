using DVLD_Enterprise_System.Application.Interfaces;
using DVLD_Enterprise_System.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DVLD_Enterprise_System.Infrastructure.Persistence;

public class DVLDDbContext : DbContext, IAppDbContext
{
    // ========================================================
    // Constructor
    // ========================================================
    //
    // ASP.NET Core يقوم بإنشاء DVLDDbContext
    // عن طريق Dependency Injection.
    //
    // DbContextOptions تحتوي على configuration
    // التي سجلناها في Program.cs.
    //
    // ومنها:
    // UseSqlServer(...)
    // Connection String
    // EF Core settings
    //
    public DVLDDbContext(
        DbContextOptions<DVLDDbContext> options)
        : base(options)
    {
    }


    // ========================================================
    // DbSets
    // ========================================================
    //
    // DbSet يمثل Entity Set داخل EF Core.
    //
    // هذا:
    //
    // DbSet<Person> People
    //
    // يسمح لنا بكتابة:
    //
    // _context.People
    //
    // بدلاً من كتابة SQL يدوياً.
    //
    // EF Core يحول LINQ إلى SQL.
    //
    public DbSet<Person> People => Set<Person>();

    public DbSet<Country> Countries => Set<Country>();

    public DbSet<User> Users => Set<User>();


    // ========================================================
    // Model Configuration
    // ========================================================
    //
    // هنا نقول لـ EF Core:
    //
    // "اذهب وابحث عن كل IEntityTypeConfiguration
    // الموجودة في Assembly الخاص بهذا DbContext
    // وقم بتطبيقها."
    //
    // لذلك EF Core سيجد مثلاً:
    //
    // PersonConfiguration
    // CountryConfiguration
    //
    // ويطبق Configure() الموجود داخل كل واحدة.
    //
    protected override void OnModelCreating(
        ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(
            typeof(DVLDDbContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }
}
