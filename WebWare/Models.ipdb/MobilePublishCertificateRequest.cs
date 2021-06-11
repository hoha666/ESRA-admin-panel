using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class MobilePublishCertificateRequest
    {
        public int Id { get; set; }
        public string TxtTitle { get; set; }
        public string TxtFname { get; set; }
        public string TxtSname { get; set; }
        public string DdlPlatform { get; set; }
        public string DdlPof { get; set; }
        public string DdlRiap { get; set; }
        public string CreatorMobilePublishCertificateRequest { get; set; }
        public string IpMobilePublishCertificateRequest { get; set; }
        public bool? RegistrationStatusMobilePublishCertificateRequest { get; set; }
        public string RegistrationDateMobilePublishCertificateRequest { get; set; }
        public string RegistrationTimeMobilePublishCertificateRequest { get; set; }
        public string AuditStatusMobilePublishCertificateRequest { get; set; }
        public string InstanceIdMobilePublishCertificateRequest { get; set; }
        public int? InstanceSridMobilePublishCertificateRequest { get; set; }
        public string DdlDiap { get; set; }
        public string TxtLink { get; set; }
        public string UplFile { get; set; }
    }
}
