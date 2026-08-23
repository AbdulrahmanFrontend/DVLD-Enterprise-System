using DVLD_Enterprise_System.API.Services.Countries;
using DVLD_Enterprise_System.Infrastructure.Persistence;
using DVLD_Enterprise_System.API.Services.People;
using DVLD_Enterprise_System.API.Middleware;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddDbContext<DVLDDbContext>(options =>
{
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DVLDDatabase"));
});

builder.Services.AddScoped<ICountryService, CountryService>();
builder.Services.AddScoped<IPersonService, PersonService>();


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseMiddleware<ExceptionHandlingMiddleware>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
