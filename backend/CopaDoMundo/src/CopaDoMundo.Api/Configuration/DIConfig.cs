using CopaDoMundo.Api.Services;
using CopaDoMundo.Api.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CopaDoMundo.Api.Configuration
{
    public static class DIConfig
    {
        public static IServiceCollection ResolverDependencias(this IServiceCollection services)
        {
            services.AddScoped<HttpClient>();
            services.AddScoped<IApiService, ApiService>();

            return services;
        }
    }
}
