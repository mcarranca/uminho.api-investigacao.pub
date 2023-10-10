using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.Extensions.Configuration;
using Microsoft.Identity.Web;
using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

// get Settings
//var settings = builder.Configuration.GetSection("Settings").Get<Settings>();

// Add services to the container.
services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer();
//.AddMicrosoftIdentityWebApi(builder.Configuration.GetSection("AzureAd"));

services.AddControllers();

//services.AddCors();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
services.AddEndpointsApiExplorer();
services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = $"Universidade do Minho | Publicações Académicas",
        Contact = new OpenApiContact
        {
            //Name = Configuration["SwaggerDocs_ContactName"],
            //Email = Configuration["SwaggerDocs_ContactEmail"]
        }
    });

    c.DocInclusionPredicate((name, api) => true);

    // conflict
    //c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());  // <- avoid
    c.IgnoreObsoleteActions();
    c.IgnoreObsoleteProperties();
    c.CustomSchemaIds(type => type.FullName);

    // JWT authentication
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description =
        "JWT Authorization header using the Bearer scheme. \r\n\r\n Enter 'Bearer' [space] and then your token in the text input below.\r\n\r\nExample: \"Bearer 12345abcdef\"",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });

    //c.AddSecurityRequirement(new OpenApiSecurityRequirement() {
    //{
    //    new OpenApiSecurityScheme
    //    {
    //        Reference = new OpenApiReference
    //        {
    //            Type = ReferenceType.SecurityScheme,
    //            Id = "Bearer"
    //        },
    //        Scheme = "oauth2",
    //        Name = "Bearer",
    //        In = ParameterLocation.Header,

    //    },
    //    new List<string>()
    //}});
});
//services.AddScoped<ICache, MemoryCache>();
services.AddMvc();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.UseStaticFiles();
app.MapControllers();
//app.MapGet("/", () => "Hello World!");


app.Run();
