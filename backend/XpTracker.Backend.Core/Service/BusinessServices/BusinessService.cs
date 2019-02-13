using System;
using System.Collections.Generic;
using System.Text;
using XpTracker.Backend.Core.Service.Log;

namespace XpTracker.Backend.Core.Service.BusinessServices
{
    internal class BusinessService
    {
        protected readonly IXpTrackerLogger _logger;

        public BusinessService(IXpTrackerLogger logger)
        {
            this._logger = logger;
        }
    }
}
