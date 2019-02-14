using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XpTracker.Backend.Core.Model;
using XpTracker.Backend.Core.Service.BusinessServices;
using XpTracker.Backend.Core.ViewModel.Experience;

namespace XpTracker.Backend.Core.Service.Facades
{
    public interface IFacadeExperienceService
    {
        Task<List<VmExperienceGet>> GetAllForCurrentUserAsync();
        Task<List<VmExperience>> Post(VmExperienceRequestPost value);
    }

    internal class FacadeExperienceService : IFacadeExperienceService
    {
        private readonly IMapper _mapper;
        private readonly IExperienceService _service;

        public FacadeExperienceService(IMapper mapper, IExperienceService service)
        {
            this._mapper = mapper;
            this._service = service;
        }

        public async Task<List<VmExperience>> Post(VmExperienceRequestPost value)
        {
            var model = _mapper.Map<VmExperienceRequestPost, Experience>(value);
            this._service.Post(model);
            // Send the list of experiences to the frontend
            var data = await this._service.GetAllForCurrentUserAsync();
            return _mapper.Map<List<Experience>, List<VmExperience>>(data);
        }

        public async Task<List<VmExperienceGet>> GetAllForCurrentUserAsync()
        {
            var data = await this._service.GetAllForCurrentUserAsync();
            return _mapper.Map<List<Experience>, List<VmExperienceGet>>(data);
        }
    }
}
