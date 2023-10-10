using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.OpenApi.Models;
using uminho.api_investigacao.pub.Setting;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
IServiceCollection services = builder.Services;

// ****************************************
// settings
// ****************************************
builder.Configuration.LoadSettings();               // appsettings.json

// ****************************************
// authentication
// ****************************************
// Add services to the container.
services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer();
//.AddMicrosoftIdentityWebApi(builder.Configuration.GetSection("AzureAd"));

services.AddControllers();

//services.AddCors();

// ****************************************
// swagger configuration
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
// ****************************************
services.AddEndpointsApiExplorer();
services.AddSwaggerGen(c => {
    c.SwaggerDoc(Settings.SwaggerSetting?.Version,
        new OpenApiInfo {
            Version = Settings.SwaggerSetting?.Version,
            Title = Settings.SwaggerSetting?.Title,
            Description = Settings.SwaggerSetting?.Description,
            Contact = new OpenApiContact {
                Name = Settings.SwaggerSetting?.ContactName,
                Email = Settings.SwaggerSetting?.ContactEMail,
                Url = string.IsNullOrWhiteSpace(Settings.SwaggerSetting?.ContactURL) ? null : new Uri(Settings.SwaggerSetting?.ContactURL ?? string.Empty),
            },
            TermsOfService = string.IsNullOrWhiteSpace(Settings.SwaggerSetting?.TermsOfService) ? null : new Uri(Settings.SwaggerSetting?.TermsOfService ?? string.Empty),
        });

    c.DocInclusionPredicate((name, api) => true);

    // conflict
    //c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());  // <- avoid
    c.IgnoreObsoleteActions();
    c.IgnoreObsoleteProperties();
    c.CustomSchemaIds(type => type.FullName);

    // JWT authentication
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme {
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

// ****************************************
// logging settings
// ****************************************

//services.AddLogging();
//builder.Logging.AddFilter();

// ****************************************
// cache
// ****************************************
//services.AddScoped<ICache, MemoryCache>();

services.AddMvc();

WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
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
