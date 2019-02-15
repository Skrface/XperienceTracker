using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerUI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using XpTracker.Backend.Core.Config;

namespace XpTracker.Backend.RestApi.Extensions
{
    /// <summary>
    /// Swagger stuff and configuration
    /// </summary>
    public static class SwaggerServiceExtensions
    {
        /// <summary>
        /// service injection
        /// </summary>
        /// <param name="services"></param>
        /// <param name="features"></param>
        /// <returns></returns>
        public static IServiceCollection AddSwaggerDocumentation(this IServiceCollection services, FeatureFlags features)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1.0", new Info { Title = "Experience tracker API v1.0", Version = "v1.0" });

                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);

                c.IncludeXmlComments(xmlPath);
                xmlPath = Path.Combine(AppContext.BaseDirectory, "XpTracker.Backend.RestApi.xml");

                c.IncludeXmlComments(xmlPath);

                if (!features.IsAnonymous)
                {
                    // Swagger 2.+ support
                    var security = new Dictionary<string, IEnumerable<string>>
                    {
                        {"Bearer", new string[] { }},
                    };

                    c.AddSecurityDefinition("Bearer", new ApiKeyScheme
                    {
                        Description = "JWT Authorization header using the Bearer scheme. Example: \"Authorization: Bearer {token}\"",
                        Name = "Authorization",
                        In = "header",
                        Type = "apiKey"
                    });
                    c.AddSecurityRequirement(security);
                }
            });

            return services;
        }

        /// <summary>
        /// swagger configuration
        /// </summary>
        /// <param name="app"></param>
        /// <returns></returns>

        public static IApplicationBuilder UseSwaggerDocumentation(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1.0/swagger.json", "Experience Tracker API v1.0");

                c.DocExpansion(DocExpansion.None);
            });

            return app;
        }
    }
}
