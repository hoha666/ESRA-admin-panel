using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class SubmitInquiries
    {
        public int Id { get; set; }
        public string HealthLetter { get; set; }
        public string HealthSletter { get; set; }
        public string HealthSletterDate { get; set; }
        public string DdlHealthSletterResult { get; set; }
        public string PoliceLetter { get; set; }
        public string PoliceSletter { get; set; }
        public string PoliceSletterDate { get; set; }
        public string DdlPoliceSletterResult { get; set; }
        public string CreatorSubmitInquiries { get; set; }
        public string IpSubmitInquiries { get; set; }
        public bool? RegistrationStatusSubmitInquiries { get; set; }
        public string RegistrationDateSubmitInquiries { get; set; }
        public string RegistrationTimeSubmitInquiries { get; set; }
        public string AuditStatusSubmitInquiries { get; set; }
        public string InstanceIdSubmitInquiries { get; set; }
        public int? InstanceSridSubmitInquiries { get; set; }
    }
}
