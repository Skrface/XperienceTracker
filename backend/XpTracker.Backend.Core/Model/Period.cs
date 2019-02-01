using System;

namespace XpTracker.Backend.Core.Model
{
    /// <summary>
    /// A period defined by one or two years
    /// </summary>
    internal class Period
    {
        public DateTime StartYear { get; set; }
        public DateTime? EndYear { get; set; }
    }
}