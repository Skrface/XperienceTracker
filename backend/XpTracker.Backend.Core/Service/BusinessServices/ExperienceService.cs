using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XpTracker.Backend.Core.Model;
using XpTracker.Backend.Core.Repo;
using XpTracker.Backend.Core.Service.Log;

namespace XpTracker.Backend.Core.Service.BusinessServices
{
    internal interface IExperienceService
    {
        List<Experience> GetAllForCurrentUser();
    }

    internal class ExperienceService : BusinessService, IExperienceService
    {
        private readonly IExperienceRepo _expRepo;

        public ExperienceService(IExperienceRepo expRepo, IXpTrackerLogger logger) : base(logger)
        {
            this._expRepo = expRepo;
        }

        public List<Experience> GetAllForCurrentUser()
        {
            return this._expRepo.GetAll().ToList();
        }
    }
}
