using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class PortalEmailSettings
    {
        public int Id { get; set; }
        public string EmailAddress { get; set; }
        public string EmailPassword { get; set; }
        public string EmailSmtpAddress { get; set; }
        public int EmailSmtpPort { get; set; }
    }
}
