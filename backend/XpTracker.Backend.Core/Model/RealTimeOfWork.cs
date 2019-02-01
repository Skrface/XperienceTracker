using XpTracker.Backend.Core.Model.Common;

namespace XpTracker.Backend.Core.Model
{
    /// <summary>
    /// The real time of work we spent. 
    /// Represented by a timespan and a value.
    /// </summary>
    internal class RealTimeOfWork : AuditableEntity<int>
    {
        public int Value { get; set; }
        public TimeSpanIndicator TimeSpan { get; set; }
    }
}