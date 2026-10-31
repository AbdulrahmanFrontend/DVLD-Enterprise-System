using DVLD_Enterprise_System.API.ExceptionHandler;
using DVLD_Enterprise_System.Application.Interfaces;
using DVLD_Enterprise_System.Application.Mappings;
using DVLD_Enterprise_System.Application.Services;
using DVLD_Enterprise_System.Infrastructure.Persistence;
using DVLD_Enterprise_System.Infrastructure.Persistence.Seeding;
using DVLD_Enterprise_System.Infrastructure.Services;
using FluentValidation;
using Mapster;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi;
using Serilog;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authentication.JwtBearer;

// 📌 2. تهيئة Serilog في السطر الأول تماماً لالتقاط أخطاء الإقلاع
Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .CreateLogger();

try
{
    Log.Logger.Information("Starting DVLD Web API application...");

    var builder = WebApplication.CreateBuilder(args);

    // 📌 3. (اختياري وموصى به) ربط Serilog مع نظام الـ Logging الداخلي في ASP.NET Core
    builder.Host.UseSerilog();

    // تسجيل معالج الأخطاء المركزي الحديث
    builder.Services.AddExceptionHandler<AdvancedGlobalExceptionHandler>();
    builder.Services.AddProblemDetails(); // تفعيل معيار الـ Problem Details القياسي

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
    // ============================================================
    // 1. تسجيل EF Core DbContext مع مرونة الاتصال (Resiliency)
    // ============================================================
    builder.Services.AddDbContext<DVLDDbContext>(options =>
    {
        options.UseSqlServer(
            builder.Configuration.GetConnectionString("DVLDDatabase"),
            sqlServerOptionsAction: sqlOptions =>
            {
                // 📌 إعادة محاولة الاتصال تلقائياً حتى 5 مرات في حال حدوث انقطاع شبكي مؤقت
                sqlOptions.EnableRetryOnFailure(
                    maxRetryCount: 5,
                    maxRetryDelay: TimeSpan.FromSeconds(30),
                    errorNumbersToAdd: null);
            });
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

    builder.Services.AddMemoryCache();

    builder.Services.AddScoped<ICountryService, CountryService>();

    // تسجيل كل الـ Validators الموجودة في الـ Application Assembly بأسطر بسيطة
    builder.Services.AddValidatorsFromAssembly(typeof(IAppDbContext).Assembly);
    builder.Services.AddScoped<IFileStorageService, LocalFileStorageService>();
    // تفعيل قراءة جميع ملفات التكوين (IRegister) الموجودة في الـ Assembly الحالي
    // أو إذا كانت الـ Mappings في مشروع الـ Application، ضع Assembly الخاص بطبقة الـ Application:
    TypeAdapterConfig.GlobalSettings.Scan(typeof(PersonMappingConfig).Assembly);
    builder.Services.AddScoped<IPersonService, PersonService>();

    builder.Services.AddScoped<IPasswordHasher, PasswordHasher>();
    builder.Services.AddScoped<IJwtTokenService, JwtTokenService>();
    builder.Services.AddScoped<IUserService, UserService>();


    // ============================================================
    // Swagger
    // ============================================================
    //
    // يسمح لنا باختبار واستكشاف REST API من المتصفح.
    //
    // ============================================================

    builder.Services.AddEndpointsApiExplorer();
    // ============================================================
    // 1. إعداد وتفعيل الـ JWT Authentication
    // ============================================================
    var jwtSettings = builder.Configuration.GetSection("Jwt");
    var secretKey = jwtSettings["Key"] ?? throw new InvalidOperationException("JWT Key is missing.");
    var key = Encoding.UTF8.GetBytes(secretKey);

    builder.Services.AddAuthentication(options =>
    {
        options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    })
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = jwtSettings["Issuer"],
            ValidAudience = jwtSettings["Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(key)
        };
    });

    builder.Services.AddAuthorization();


    // ============================================================
    // 2. تحديث Swagger ليدعم إدخال الـ Bearer Token (متوافق مع .NET 10 و Swashbuckle 10)
    // ============================================================
    builder.Services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc("v1", new OpenApiInfo { Title = "DVLD Enterprise API", Version = "v1" });

        // 1. تعريف وسيلة الحماية (Bearer Token)
        c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
        {
            Description = "أدخل الـ Token بهذه الصيغة: Bearer {مسافة ثم الـ Token هنا}",
            Name = "Authorization",
            In = ParameterLocation.Header,
            Type = SecuritySchemeType.Http,
            Scheme = "Bearer",
            BearerFormat = "JWT"
        });

        // 2. ربط الشروط بالطريقة الحديثة لـ Swashbuckle 10 (بدون الحاجة لـ OpenApiReference القديم)
        c.AddSecurityRequirement(document => new OpenApiSecurityRequirement
        {
            [new OpenApiSecuritySchemeReference("Bearer", document)] = new List<string>()
        });
    });


    // ============================================================
    // 3. بناء التطبيق
    // ============================================================
    //
    // هنا يتم تحويل الـ configuration التي قمنا بتجهيزها
    // إلى WebApplication فعلي.
    // ============================================================

    var app = builder.Build();

    // 🟢 تفعيل معالج الأخطاء العالمي (هذا هو السطر الصحيح بدلاً من UseMiddleware)
    app.UseExceptionHandler();

    // ============================================================
    // تطبيق الـ Migrations وزرع البيانات الثابتة تلقائياً عند الإقلاع
    // ============================================================
    using (var scope = app.Services.CreateScope())
    {
        var services = scope.ServiceProvider;
        try
        {
            var context = services.GetRequiredService<DVLDDbContext>();
            
            // 1. جلب خدمة تشفير كلمات المرور المسجلة في الـ DI
            var passwordHasher = services.GetRequiredService<IPasswordHasher>();

            // 1. تطبيق الجداول تلقائياً
            context.Database.Migrate();

            // 2. حقن وزرع البيانات الثابتة (Lookup Tables)
            await DbSeeder.SeedAsync(context);
            var adminUser = await DbSeeder.SeedPersonalDataForAdminUserAsync(context);

            if (adminUser != null)
            {
                adminUser.PasswordHash = passwordHasher.HashPassword(
                    adminUser,
                    "Admin@12345");

                await context.AddAsync(adminUser);
                await context.SaveChangesAsync();
            }
        }
        catch (Exception ex)
        {
            var logger = services.GetRequiredService<ILogger<Program>>();
            logger.LogError(ex, "An error occurred while migrating or seeding the database.");
        }
    }

    // ... باقي الـ Middleware والـ Controllers

    // 📌 تفعيل قراءة الملفات الثابتة من مجلد wwwroot
    app.UseStaticFiles();


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


    // 🛑 الترتيب مهم جداً هنا:
    app.UseAuthentication(); // 1. التحقق من هوية المستخدم (فك الـ Token)
    app.UseAuthorization();  // 2. التحقق من صلاحياته (Roles / Policies)


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
}
catch (Exception ex)
{
    Log.Fatal(ex, "Application terminated unexpectedly!");
}
finally
{
    Log.CloseAndFlush();
}