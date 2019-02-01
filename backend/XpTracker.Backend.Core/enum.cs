using System;
using System.Collections.Generic;
using System.Text;

namespace XpTracker.Backend.Core
{
    /// <summary>
    /// Code of the supported languages
    /// </summary>
    public enum LanguageCode
    {
        /// <summary>
        /// shouldn't be used
        /// </summary>
        UNKNOWN = 0,

        /// <summary>
        /// French 
        /// </summary>
        FR = 1,

        /// <summary>
        /// English
        /// </summary>
        EN = 2,

        /// <summary>
        /// German
        /// </summary>
        DE = 3,

        /// <summary>
        /// Italian
        /// </summary>
        IT = 4,

        /// <summary>
        /// Spanish
        /// </summary>
        SP = 5,

        /// <summary>
        /// Russian
        /// </summary>
        RU = 6,

        /// <summary>
        /// Chinese
        /// </summary>
        CH = 7,

    }

    /// <summary>
    /// Indicate the time span like days, weeks, months, years
    /// </summary>
    public enum TimeSpanIndicator
    {
        /// <summary>
        /// shouldn't be used
        /// </summary>
        UNKNOWN = 0,

        /// <summary>
        /// Number of day 
        /// </summary>
        DAY = 1,

        /// <summary>
        /// Number of week 
        /// </summary>
        WEEK = 2,

        /// <summary>
        /// Number of month 
        /// </summary>
        MONTH = 3,

        /// <summary>
        /// Number of year 
        /// </summary>
        YEAR = 4,
    }

    /// <summary>
    /// Type of technology
    /// </summary>
    public enum TechnologyType
    {
        /// <summary>
        /// shouldn't be used
        /// </summary>
        UNKNOWN = 0,

        /// <summary>
        /// Code 
        /// </summary>
        CODE = 1,

        /// <summary>
        /// Environment 
        /// </summary>
        ENV = 2,
    }
}
