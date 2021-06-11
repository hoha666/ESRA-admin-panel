using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class PublisherSubmit
    {
        public int Id { get; set; }
        public string TxtPublisherName { get; set; }
        public string TxtSubmitCode { get; set; }
        public string TxtPublisherId { get; set; }
        public string LicenseExpiryDate { get; set; }
        public string SubmitDate { get; set; }
        public string Phone { get; set; }
        public string TxaAddress { get; set; }
        public string TxtZipCode { get; set; }
        public string TxtWebSite { get; set; }
        public string Email { get; set; }
        public string CreatorPublisherSubmit { get; set; }
        public string IpPublisherSubmit { get; set; }
        public bool? RegistrationStatusPublisherSubmit { get; set; }
        public string RegistrationDatePublisherSubmit { get; set; }
        public string RegistrationTimePublisherSubmit { get; set; }
        public string AuditStatusPublisherSubmit { get; set; }
        public string InstanceIdPublisherSubmit { get; set; }
        public int? InstanceSridPublisherSubmit { get; set; }
    }
}
