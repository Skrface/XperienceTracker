using System;
using System.Collections.Generic;
using System.Text;

namespace XpTracker.Backend.Core
{
    /// <summary>
    /// Constants
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// Constants used in Entity Framework
        /// </summary>
        public static class EF
        {
            /// <summary>
            /// column lenght for codes related data
            /// </summary>
            public const string NVARCHAR_LENGTH_CODE = "varchar(256)";
            /// <summary>
            /// column lenght for freetext related data
            /// </summary>
            public const string NVARCHAR_LENGTH_FREETEXT = "varchar(4000)";
        }
    }
}
