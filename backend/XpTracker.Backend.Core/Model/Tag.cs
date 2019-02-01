using XpTracker.Backend.Core.Model.Common;

namespace XpTracker.Backend.Core.Model
{
    /// <summary>
    /// A tag is used to find specific experiences by keywords
    /// </summary>
    internal class Tag : AuditableEntity<int>
    {
        public string Name { get; set; }
    }
}