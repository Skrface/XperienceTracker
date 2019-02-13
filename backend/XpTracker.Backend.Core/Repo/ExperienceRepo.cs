using System;
using System.Collections.Generic;
using System.Text;
using XpTracker.Backend.Core.Model;
using XpTracker.Backend.Core.Repo.Common;
using XpTracker.Backend.Core.Service.Log;

namespace XpTracker.Backend.Core.Repo
{
    internal interface IExperienceRepo : IBaseRepo<Experience>
    {

    }

    internal class ExperienceRepo : BaseRepo<Experience>, IExperienceRepo
    {
        public ExperienceRepo(XpTrackerDbContext context, IXpTrackerLogger logger) : base(context, logger)
        {
        }



    }
}
