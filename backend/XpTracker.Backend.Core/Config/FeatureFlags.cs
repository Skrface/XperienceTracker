using System;
using System.Collections.Generic;
using System.Text;

namespace XpTracker.Backend.Core.Config
{
    /// <summary>
    /// Feature flags
    /// </summary>
    public class FeatureFlags
    {
        /// <summary>
        /// default values
        /// </summary>
        public FeatureFlags()
        {
            IsAnonymous = false;
            IsInMemoryDb = false;
            IsMailDisabled = false;
        }

        /// <summary>
        /// true if the application should be unAuthenticated
        /// </summary>
        public bool IsAnonymous { get; set; }

        /// <summary>
        /// true to use an In Memory / mock database
        /// </summary>
        public bool IsInMemoryDb { get; set; }

        /// <summary>
        /// true means that the application will NOT send emails
        /// </summary>
        public bool IsMailDisabled { get; set; }

        /// <summary>
        /// true means that data are not encrypted in the database
        /// </summary>
        public bool IsDbEncryptionDisabled { get; set; }
    }
}
