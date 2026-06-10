using BusinessLayer.Implementation.LogInService;
using BusinessLayer.Implementation.NoteServiceImpl;
using BusinessLayer.Implementation.RegisterService;
using BusinessLayer.Interface.LogInServiceInterface;
using BusinessLayer.Interface.NoteServiceInterface;
using BusinessLayer.Interface.RegisterServiceInterface;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi;
using NLog;
using NLog.Web;
using RepositoryLayer.Context;
using RepositoryLayer.Implementation.LogInImpl;
using RepositoryLayer.Implementation.NoteImpl;
using RepositoryLayer.Implementation.RegisterImpl;
using RepositoryLayer.Interface.INoteInterface;
using RepositoryLayer.Interface.LogInIntarface;
using RepositoryLayer.Interface.RegisterInterface;
using System.Text;






var logger = LogManager.Setup().LoadConfigurationFromFile("nlog.config").GetCurrentClassLogger();
try
{
    var builder = WebApplication.CreateBuilder(args);


    builder.Logging.ClearProviders();
    builder.Host.UseNLog();

    //Dependency Injection
    builder.Services.AddScoped<IRegisterRepo, RegisterImplREpo>();
    builder.Services.AddScoped<IRegisterService, RegisterImplService>();
    builder.Services.AddScoped<ILogInRepo,LogInImplRepo>();
    builder.Services.AddScoped<ILogInService, LogInServiceImpl>();
    builder.Services.AddScoped<BusinessLayer.Helper.Password>();
    builder.Services.AddScoped<BusinessLayer.Helper.GenerateToken>();
    builder.Services.AddScoped<INoteService,NotesServiceImpl>();
    builder.Services.AddScoped<INoteInterface,NoteRepoImpl>();

    //builder.Services.AddDbContext<UserContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("connection")));
    //builder.Services.AddDbContext<NotesContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("connection")));
    builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("connection")));
    // Add services to the container.

    builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,

            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            ValidAudience = builder.Configuration["Jwt:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"])
            )
        };

    });

    builder.Services.AddControllers();
    // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
    builder.Services.AddOpenApi();
    builder.Services.AddEndpointsApiExplorer();
    

    builder.Services.AddSwaggerGen(options =>
    {
       
        options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
        {
            Name = "Authorization",
            Type = SecuritySchemeType.Http,
            Scheme = "Bearer",
            BearerFormat = "JWT",
            In = ParameterLocation.Header,
            Description = "Enter 'Bearer' [space] and then your token.\nExample: Bearer abc123"
        });


        options.AddSecurityRequirement(document => new OpenApiSecurityRequirement
        {
            [new OpenApiSecuritySchemeReference("Bearer", document)] = []
        });
    });


    var app = builder.Build();
   


    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.MapOpenApi();
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();

    app.UseRouting(); 

    app.UseAuthentication();
    app.UseAuthorization();

    app.MapControllers();

    app.Run();
}
catch (Exception ex)
{
    logger.Error(ex, "Application stopped due to exception");
    throw;
}
finally
{
    LogManager.Shutdown();
}
