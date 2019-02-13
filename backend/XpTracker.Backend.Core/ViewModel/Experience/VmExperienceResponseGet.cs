using System;
using System.Collections.Generic;
using System.Text;
using XpTracker.Backend.Core.ViewModel.Common;

namespace XpTracker.Backend.Core.ViewModel.Experience
{
    /// <summary>
    /// Experience GET endpoint payload
    /// </summary>
    public class VmExperienceResponseGet : VmBase
    {
        /// <summary>
        /// The actual data
        /// </summary>
        public List<VmExperienceGet> Data { get; set; }
    }
}
