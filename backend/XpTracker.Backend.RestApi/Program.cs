using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using XpTracker.Backend.Core.DataMapper;

namespace XpTracker.Backend.RestApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                var host = CreateWebHostBuilder(args);

                try
                {
                    //RunSeedingAsync(host);
                }
                catch (Exception e)
                {
                    // TODO Add log to say there is something wrong while creating/updating/filling the database
                    System.Console.Out.WriteLine(e.Message);
                }

                host.Run();
            }
            catch (Exception e)
            {
                // TODO Add log to say there is something wrong 
                System.Console.Out.WriteLine(e.Message);
            }
        }

        public static IWebHost CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .ConfigureAppConfiguration((ctx, builder) =>
                {
                    //Build the config from sources we have
                    var config = builder.Build();
                    //Add Key Vault to configuration pipeline
                    //builder.AddAzureKeyVault(config["KeyVault:Url"]);
                })
                .Build();

        /// <summary>
        /// Seed the database    
        /// </summary>
        /// <param name="host"></param>
        private static void RunSeedingAsync(IWebHost host)
        {
            var scopeFactory = host.Services.GetService<IServiceScopeFactory>();

            using (var scope = scopeFactory.CreateScope())
            {
                var seeder = scope.ServiceProvider.GetService<XpTrackerSeeder>();
                seeder.SeedAsync().Wait();
            }
        }
    }
}
