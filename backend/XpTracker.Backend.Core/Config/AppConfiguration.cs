using System;
using System.Collections.Generic;
using System.Text;

namespace XpTracker.Backend.Core.Config
{
    /// <summary>
    /// Application configuration (either in env vars or in a JSON file)
    /// </summary>
    public class AppConfiguration
    {
        /// <summary>
        /// constructor with default values
        /// </summary>
        public AppConfiguration()
        {
            //this.APPINSIGHTS_CUSTOMLOGLEVEL = "WARNING";
        }
        //public string APPINSIGHTS_INSTRUMENTATIONKEY { get; set; }
        //public string APPINSIGHTS_CUSTOMLOGLEVEL { get; set; }
        public ConnectionStrings ConnectionStrings { get; set; }

        public FeatureFlags FeatureFlags { get; set; }

        public EmailConfig EmailConfig { get; set; }

        //public Azuread AzureAd { get; set; }



        //public SharePointConfig SharePointConfig { get; set; }
    }
}
