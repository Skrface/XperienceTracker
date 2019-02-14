using System;
using System.Collections.Generic;
using System.Text;

namespace XpTracker.Backend.Core.Config
{
    public class EmailConfig
    {
        public string SmtpAddress { get; set; }
        public int SmtpPort { get; set; }
        public string SmtpUsername { get; set; }
        private string _password;
        public string SmtpPassword { get; set; }
    }
}
