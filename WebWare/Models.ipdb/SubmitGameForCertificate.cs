using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class SubmitGameForCertificate
    {
        public int Id { get; set; }
        public string CreatorSubmitGameForCertificate { get; set; }
        public string IpSubmitGameForCertificate { get; set; }
        public bool? RegistrationStatusSubmitGameForCertificate { get; set; }
        public string RegistrationDateSubmitGameForCertificate { get; set; }
        public string RegistrationTimeSubmitGameForCertificate { get; set; }
        public string AuditStatusSubmitGameForCertificate { get; set; }
        public string InstanceIdSubmitGameForCertificate { get; set; }
        public int? InstanceSridSubmitGameForCertificate { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
