using FlagExplorer.Core.Common;
using FlagExplorer.Core.Interfaces;
using FlagExplorer.Service.Interfaces;
using FlagExplorer.Service.Services;
using FlagExplorer.Service.Shared;
using FlagExplorer.WebAPI;
using FlagExplorer.WebAPI.Repositories;
using HostInitActions;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;

var builder = WebApplication.CreateBuilder(args);
builder.Services.Configure<RouteOptions>(options => options.LowercaseUrls = true);

// Add AutoMapper
builder.Services.AddAutoMapper(typeof(AutoMapperProfile));
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

//Add authorization for Swagger
builder.Services.AddSwaggerGen(
    options =>
    {
        options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
        {
            Description = "Bearer token authentication",
            Name = "Authorization",
            In = ParameterLocation.Header,
            Scheme = "Bearer"
        }
        );

        options.OperationFilter<SecurityRequirementsOperationFilter>();
    }
);

var environmenKeys = new EnvironmentVariable();
builder.Configuration.GetSection("EnvironmentKeys").Bind(environmenKeys);

var spaStaticFiles = new EnvironmentVariable();
builder.Configuration.GetSection("SpaStaticFiles").Bind(spaStaticFiles);

var connectionStringKey = environmenKeys.Dev;
var frontEndPath = spaStaticFiles.Dev;

if (builder.Environment.IsProduction())
{
    connectionStringKey = environmenKeys.Prod;
    frontEndPath = spaStaticFiles.Prod;
}
else if (builder.Environment.IsStaging())
{
    connectionStringKey = environmenKeys.Staging;
    frontEndPath = spaStaticFiles.Staging;
}

//SpaStaticFiles
builder.Services.AddSpaStaticFiles(configuration =>
{
    configuration.RootPath = frontEndPath!;
});


// CORS
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        policy =>
        {
            policy.AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
});


// Service registration
builder.Services.AddSingleton<ICountryRepository, CountryRepository>();
builder.Services.AddScoped<ICountryService, CountryService>();
builder.Services.AddAsyncServiceInitialization()
    .AddInitAction<ICountryRepository>(async (service) =>
    {
        await service.InitAsync();
    });

DependencyInjectionHelper.RegisterEntities(builder);

var app = builder.Build();

app.UseSpaStaticFiles();

app.UseCors();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseSpa(spa =>
{
    //if (builder.Environment.IsDevelopment())
    //{
    //    spa.Options.SourcePath = Path.Combine("..", "..", "frontend");
    //    spa.UseReactDevelopmentServer(npmScript: "start");
    //}
});
app.Run();
