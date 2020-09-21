using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace CopaDoMundo.Api.Configuration
{
    public static class CorsConfig
    {
        public static IServiceCollection AddCorsConfig(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder => builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());
            });

            return services;
        }

        public static IApplicationBuilder UseCorsConfig(this IApplicationBuilder app)
        {

            app.UseCors("CorsPolicy");
            return app;
        }


    }
}
