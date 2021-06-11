using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class CheckingGameCertificateR
    {
        public int Id { get; set; }
        public string Result { get; set; }
        public string MobileCode { get; set; }
        public string CreatorCheckingGameCertificateR { get; set; }
        public string IpCheckingGameCertificateR { get; set; }
        public bool? RegistrationStatusCheckingGameCertificateR { get; set; }
        public string RegistrationDateCheckingGameCertificateR { get; set; }
        public string RegistrationTimeCheckingGameCertificateR { get; set; }
        public string AuditStatusCheckingGameCertificateR { get; set; }
        public string InstanceIdCheckingGameCertificateR { get; set; }
        public int? InstanceSridCheckingGameCertificateR { get; set; }
        public string Comment { get; set; }
        public string DateStart { get; set; }
        public DateTime? DateStartGregorian { get; set; }
        public string DateEnd { get; set; }
        public DateTime? DateEndGregorian { get; set; }
    }
}
