using DVLD_Enterprise_System.API.Middleware;
using DVLD_Enterprise_System.Application.Interfaces;
using DVLD_Enterprise_System.Application.Services.Countries;
using DVLD_Enterprise_System.Application.Services.People;
using DVLD_Enterprise_System.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// ============================================================
// 1. إنشاء WebApplicationBuilder
// ============================================================
// builder مسؤول عن تجهيز التطبيق قبل تشغيله.
// من خلاله نقوم بتسجيل:
// - Services
// - Database
// - Configuration
// - Logging
// - وغيرها من dependencies.
//
// builder.Services هو IServiceCollection
// ============================================================

builder.Services.AddControllers();

// تسجيل EF Core DbContext داخل Dependency Injection.
//
// AddDbContext تجعل DVLDDbContext متاحاً تلقائياً
// لأي Service أو Controller يطلبه في constructor.
//
// كما تحدد أن EF Core سيستخدم SQL Server
// وأن Connection String موجود في Configuration.
//
// عمر DbContext هنا Scoped:
// يتم إنشاء instance لكل HTTP Request تقريباً
// ثم يتم التخلص منه بعد انتهاء الطلب.
builder.Services.AddDbContext<DVLDDbContext>(options =>
{
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DVLDDatabase"));
});


// ============================================================
// Application Services
// ============================================================
//
// Controllers depend on application-service abstractions.
//
// Example:
//
// IPersonService
//      ↓
// PersonService
//
// The service contains application-level orchestration and rules.
// ============================================================

builder.Services.AddScoped<IAppDbContext, DVLDDbContext>();
builder.Services.AddScoped<ICountryService, CountryService>();
builder.Services.AddScoped<IPersonService, PersonService>();


// ============================================================
// Infrastructure Implementations
// ============================================================
//
// Application depends only on repository abstractions:
//
// IPersonRepository
// ICountryRepository
// IUnitOfWork
//
// Infrastructure provides their concrete implementations:
//
// IPersonRepository → PersonRepository
// ICountryRepository → CountryRepository
// IUnitOfWork → UnitOfWork
//
// This allows Application to remain independent from EF Core
// and SQL Server implementation details.
// ============================================================


// ============================================================
// Swagger
// ============================================================
//
// يسمح لنا باختبار واستكشاف REST API من المتصفح.
//
// ============================================================

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// ============================================================
// 3. بناء التطبيق
// ============================================================
//
// هنا يتم تحويل الـ configuration التي قمنا بتجهيزها
// إلى WebApplication فعلي.
// ============================================================

var app = builder.Build();


// ============================================================
// 4. Middleware Pipeline
// ============================================================
//
// كل HTTP Request يمر عبر Middleware Pipeline.
//
// ExceptionHandlingMiddleware موجود في بداية الـ pipeline
// حتى يستطيع التقاط Exceptions التي تحدث في الطبقات التي بعده.
//
// مثال:
//
// Client
//   ↓
// ExceptionHandlingMiddleware
//   ↓
// HTTPS
//   ↓
// Authorization
//   ↓
// Controller
//   ↓
// Service
//   ↓
// EF Core
//   ↓
// SQL Server
//
// إذا حدث Exception في Controller أو Service أو EF Core:
// يرجع إلى Middleware ويقوم Middleware بمعالجته.
// ============================================================

app.UseMiddleware<ExceptionHandlingMiddleware>();


// ============================================================
// 5. Swagger فقط في Development
// ============================================================

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


// إجبار HTTP على التحويل إلى HTTPS.
app.UseHttpsRedirection();


// Middleware الخاص بالـ Authorization.
// لاحقاً عندما نضيف Authentication + JWT
// سيصبح هذا مهماً جداً.
//app.UseAuthorization();


// ============================================================
// 6. ربط Controllers بالـ Routing System
// ============================================================
//
// يجعل ASP.NET Core يبحث عن Controllers
// ويطابق HTTP Requests مع Actions.
//
// مثال:
//
// GET /api/People
//
// ↓
//
// PeopleController.GetAll()
//
// ============================================================

app.MapControllers();


// ============================================================
// 7. تشغيل Web Server
// ============================================================
//
// هنا يبدأ التطبيق فعلياً في استقبال HTTP Requests.
// ============================================================

app.Run();