using System;
using System.Collections.Generic;
using System.Text;

namespace XpTracker.Backend.Core.ViewModel.Common
{
    /// <summary>
    /// Base class for returned payload from the API
    /// </summary>
    public class VmBase
    {
#if VERBOSE
        /// <summary>
        /// is the request a success
        /// </summary>
        public bool Success { get; set; }
#endif
        /// <summary>
        /// Eventually, a human readable message can be usefull
        /// </summary>
        public String Message { get; set; }

        /// <summary>
        /// TODO : utiliser un truc du style https://github.com/stevejgordon/CorrelationId/
        /// </summary>
        public Guid CorrelationId { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public VmBase()
        {
#if VERBOSE
            Success = true;
#endif
        }

    }
}
