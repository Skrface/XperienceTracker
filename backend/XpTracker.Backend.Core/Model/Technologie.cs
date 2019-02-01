using XpTracker.Backend.Core.Model.Common;

namespace XpTracker.Backend.Core.Model
{
    /// <summary>
    /// A technology represents an area of expertise
    /// </summary>
    internal class Technologie : AuditableEntity<int>
    {
        public string Name { get; set; }
        public TechnologyType TechnologyType { get; set; }
    }
}