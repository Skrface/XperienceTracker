using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XpTracker.Backend.Core.Model;
using XpTracker.Backend.Core.Service.BusinessServices;
using XpTracker.Backend.Core.ViewModel.Experience;

namespace XpTracker.Backend.Core.Service.Facades
{
    public interface IFacadeExperienceService
    {
        List<VmExperienceGet> GetAllForCurrentUser();
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

        public List<VmExperienceGet> GetAllForCurrentUser()
        {
            var data = this._service.GetAllForCurrentUser();
            return _mapper.Map<List<Experience>, List<VmExperienceGet>>(data);
        }
    }
}
