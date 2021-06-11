using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class CompanyRegistration
    {
        public int Id { get; set; }
        public string CompanyRegistrationLetter { get; set; }
        public string CompanyRegistrationSletter { get; set; }
        public string CompanyRegistrationSletterDate { get; set; }
        public string TxtCompanyRegistrationId { get; set; }
        public string TxtCompanyName { get; set; }
        public string CompanyRegistrationDate { get; set; }
        public string CreatorCompanyRegistration { get; set; }
        public string IpCompanyRegistration { get; set; }
        public bool? RegistrationStatusCompanyRegistration { get; set; }
        public string RegistrationDateCompanyRegistration { get; set; }
        public string RegistrationTimeCompanyRegistration { get; set; }
        public string AuditStatusCompanyRegistration { get; set; }
        public string InstanceIdCompanyRegistration { get; set; }
        public int? InstanceSridCompanyRegistration { get; set; }
    }
}
