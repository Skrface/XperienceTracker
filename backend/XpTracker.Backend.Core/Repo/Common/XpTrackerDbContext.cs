using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using XpTracker.Backend.Core.DataMapper;
using XpTracker.Backend.Core.Model;
using XpTracker.Backend.Core.Model.Common;

namespace XpTracker.Backend.Core.Repo.Common
{
    public interface IXpTrackerDbContext
    {
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        int SaveChanges();
    }

    public class XpTrackerDbContext : DbContext, IXpTrackerDbContext
    {
        public XpTrackerDbContext(DbContextOptions<XpTrackerDbContext> options, IConfiguration configuration) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new ExperienceMap(modelBuilder.Entity<Experience>());            
            new TagMap(modelBuilder.Entity<Tag>());
            new TechnologyMap(modelBuilder.Entity<Technology>());

            new UserMap(modelBuilder.Entity<User>());
        }

        private void setAuditableProperties()
        {
            var modifiedEntries = ChangeTracker.Entries()
              .Where(x => x.Entity is IAuditableEntity
                  && (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach (var entry in modifiedEntries)
            {
                IAuditableEntity entity = entry.Entity as IAuditableEntity;
                if (entity != null)
                {
                    string identityName = Thread.CurrentPrincipal?.Identity?.Name;
                    DateTime now = DateTime.UtcNow;

                    if (entry.State == EntityState.Added)
                    {
                        entity.CreatedBy = identityName;
                        entity.CreatedDate = now;
                    }
                    else
                    {
                        base.Entry(entity).Property(x => x.CreatedBy).IsModified = false;
                        base.Entry(entity).Property(x => x.CreatedDate).IsModified = false;
                    }

                    entity.UpdatedBy = identityName;
                    entity.UpdatedDate = now;
                }
            }
        }
        public override int SaveChanges()
        {
            setAuditableProperties();

            return base.SaveChanges();
        }
    }
}
