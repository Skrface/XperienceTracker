using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XpTracker.Backend.Core.Model;
using XpTracker.Backend.Core.Repo;
using XpTracker.Backend.Core.Service.Log;

namespace XpTracker.Backend.Core.Service.BusinessServices
{
    internal interface IExperienceService
    {
        Task<List<Experience>> GetAllForCurrentUserAsync();
        Experience Post(Experience model);
    }

    internal class ExperienceService : BusinessService, IExperienceService
    {
        private readonly IExperienceRepo _expRepo;

        public ExperienceService(IExperienceRepo expRepo, IXpTrackerLogger logger) : base(logger)
        {
            this._expRepo = expRepo;
        }

        public Experience Post(Experience model)
        {
            this._expRepo.Create(model);
            this._expRepo.SaveChanges();

            return model;
        }

        public async Task<List<Experience>> GetAllForCurrentUserAsync()
        {
            return await this._expRepo.GetAll().ToListAsync();
        }
    }
}
