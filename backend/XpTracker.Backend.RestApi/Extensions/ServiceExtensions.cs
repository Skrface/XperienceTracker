using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XpTracker.Backend.RestApi.Extensions
{
    public static class ServiceExtensions
    {
        // Enable CORS Policy to enable cross domain client-server requests
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                // Non restrictive way
                options.AddPolicy("CorsPolicy",                    
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials());

                // More restrictive way
                //options.AddPolicy("CorsPolicy",
                //builder => builder.WithOrigins("http://www.something.com")
                //.WithMethods("POST", "GET")
                //.WithHeaders("accept", "content-type"));
            });
        }

        // Configure IIS integration for easier IIS deployment
        public static void ConfigureIISIntegration(this IServiceCollection services)
        {
            services.Configure<IISOptions>(options =>
            {
                // Default values here
                options.AutomaticAuthentication = true;
                options.AuthenticationDisplayName = null;
                options.ForwardClientCertificate = true;
            });
        }
    }
}
