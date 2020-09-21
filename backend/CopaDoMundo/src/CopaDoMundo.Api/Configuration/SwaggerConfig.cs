using Microsoft.Extensions.DependencyInjection;
using System;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Builder;
using System.Reflection;
using System.IO;

namespace CopaDoMundo.Api.Configuration
{
    public static class SwaggerConfig
    {
        public static IServiceCollection AddSwaggerConfig(this IServiceCollection services)
        {
            services.AddSwaggerGen(c => {

                c.SwaggerDoc("v1",
                    new OpenApiInfo
                    {
                        Title = "Copa do Mundo de Filmes",
                        Version = "v1",
                        Description = "Api criado para o Copa do Mundo de Filmes",
                        Contact = new OpenApiContact
                        {
                            Name = "Leo Souza",
                            Url = new Uri("https://github.com/leosouza-dev")
                        }
                    });

                // Set the comments path for the Swagger JSON and UI.
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });

            return services;
        }
        public static IApplicationBuilder UseSwaggerConfig(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Copa do Mundo de Filmes V1");
            });

            return app;
        }


    }
}
