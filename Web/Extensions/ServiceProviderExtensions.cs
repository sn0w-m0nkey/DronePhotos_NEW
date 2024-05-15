using System.Text.Json.Serialization;
using Data.Contexts;
using Data.Entities;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Web.Components.Account;
using Web.Configuration;
using Web.Services;

namespace Web.Extensions;

public static class ServiceProviderExtensions
{
    public static IServiceCollection RegisterWebComponents(this IServiceCollection services, IConfiguration configuration)
    {
        AddControllers(services, configuration);
        ConfigureOptions(services, configuration);
        RegisterServices(services);

        return services;
    }

    public static IServiceCollection RegisterDataComponents(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("ApplicationDbContext")));
        
        services.AddDbContext<PhotosDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("PhotosDbContext")));

        // services.AddDbContext<ApplicationDbContext>(
        //     options =>
        //         options.UseSqlServer(
        //             configuration.GetConnectionString("ApplicationDbContext"),
        //             x => x.MigrationsAssembly("Data")));
                
        services.AddDatabaseDeveloperPageExceptionFilter();
        
        return services;
    }
    
    public static IServiceCollection ConfigureAuthentication(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddCascadingAuthenticationState();
        services.AddScoped<IdentityUserAccessor>();
        services.AddScoped<IdentityRedirectManager>();
        services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();
        services.AddAuthentication(options =>
            {
                options.DefaultScheme = IdentityConstants.ApplicationScheme;
                options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
            })
            .AddIdentityCookies();

        services.AddIdentityCore<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
            .AddRoles<IdentityRole>()
            .AddEntityFrameworkStores<ApplicationDbContext>()
            .AddSignInManager()
            .AddDefaultTokenProviders();

        return services;
    }

    private static IServiceCollection AddControllers(IServiceCollection services, IConfiguration configuration)
    {
        services
            .AddControllers()
            .AddJsonOptions(options => options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));

        return services;
    }

    private static void ConfigureOptions(IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<ApiConfig>(configuration.GetSection(ApiConfig.SectionName));
        services.Configure<GmailConfig>(configuration.GetSection(GmailConfig.SectionName));
    }

    private static void RegisterServices(IServiceCollection services)
    {
        //services.AddSingleton<IEmailSender<ApplicationUser>, IdentityNoOpEmailSender>();
        services.AddSingleton<IEmailSender<ApplicationUser>, EmailSender>();
        services.AddSingleton<IMailService, MailService>();
        // services.AddSingleton<IMailService_NetMail, MailService_NetMail>();
        // services.AddScoped<IPhotoService, PhotoService>();
        // services.AddScoped<IImageUploader, ImageUploader>();
        
        // services.AddSingleton<WeatherForecastService>();
    }
}
