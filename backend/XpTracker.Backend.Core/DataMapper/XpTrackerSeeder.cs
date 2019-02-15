using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XpTracker.Backend.Core.Repo.Common;

namespace XpTracker.Backend.Core.DataMapper
{
    public class XpTrackerSeeder
    {
        private readonly XpTrackerDbContext _ctx;

        public XpTrackerSeeder(XpTrackerDbContext ctx)
        {
            this._ctx = ctx;
        }

        public async Task SeedAsync()
        {
            await _ctx.Database.EnsureCreatedAsync();
            //_ctx.Database.Migrate();
        }
    }
}
