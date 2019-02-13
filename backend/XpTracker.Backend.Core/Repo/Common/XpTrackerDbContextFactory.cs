using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace XpTracker.Backend.Core.Repo.Common
{
    internal class XpTrackerDbContextFactory : IDesignTimeDbContextFactory<XpTrackerDbContext>
    {
        public XpTrackerDbContext CreateDbContext(string[] args)
        {
            //This context is used when developping the app. When you do an add-migration, 
            //the tooling will create a dbcontext to check the version of the db schema with this factory
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .AddJsonFile("appsettings.Development.json")
            .Build();
            var builder = new DbContextOptionsBuilder<XpTrackerDbContext>();
            var connectionString = configuration.GetConnectionString("XpTrackerDbConnection");
            builder.UseNpgsql(connectionString);
            return new XpTrackerDbContext(builder.Options, configuration);
        }

    }
}
