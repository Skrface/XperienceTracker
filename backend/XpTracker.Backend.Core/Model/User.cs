using System;
using System.Collections.Generic;
using System.Text;
using XpTracker.Backend.Core.Model.Common;

namespace XpTracker.Backend.Core.Model
{
    /// <summary>
    /// an application user
    /// </summary>
    internal class User : AuditableEntity<int>
    {
        /// <summary>
        /// The user's email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The user's display name
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// The user's experiences
        /// </summary>
        public IEnumerable<Experience> Experiences { get; set; }
    }
}
