using Microsoft.Extensions.DependencyInjection;

namespace FootballArchive.Infrastructure.Extensions.Service
{
    public static class Service
    {
        public static void ConfigureCors(this IServiceCollection services, string[] origins)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                {
                    builder.WithOrigins(origins)
                            .AllowAnyMethod()
                            .AllowAnyHeader();
                });
            });
        }

        public static void ConfigureIISIntegration(this IServiceCollection services)
        {
        }
    }
}