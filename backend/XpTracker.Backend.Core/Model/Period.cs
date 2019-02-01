using System;
using XpTracker.Backend.Core.Model.Common;

namespace XpTracker.Backend.Core.Model
{
    /// <summary>
    /// A period defined by one or two years
    /// </summary>
    internal class Period : AuditableEntity<int>
    {
        public DateTime StartYear { get; set; }
        public DateTime? EndYear { get; set; }
    }
}