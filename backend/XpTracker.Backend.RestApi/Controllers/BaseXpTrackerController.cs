using Microsoft.AspNetCore.Mvc;
using XpTracker.Backend.Core.Service.Log;

namespace XpTracker.Backend.RestApi.Controllers
{
    /// <summary>
    /// Custom base controller
    /// </summary>
    public class BaseXpTrackerController : ControllerBase
    {
        protected readonly IXpTrackerLogger _logger;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="logger"></param>
        public BaseXpTrackerController(IXpTrackerLogger logger)
        {
            this._logger = logger;
        }
    }
}