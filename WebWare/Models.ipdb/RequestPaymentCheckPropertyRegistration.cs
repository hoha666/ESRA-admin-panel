using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RequestPaymentCheckPropertyRegistration
    {
        public int Id { get; set; }
        public string DdlPropertyRegistration { get; set; }
        public string AxtDescription { get; set; }
        public string CreatorRequestPaymentCheckPropertyRegistration { get; set; }
        public string IpRequestPaymentCheckPropertyRegistration { get; set; }
        public bool? RegistrationStatusRequestPaymentCheckPropertyRegistration { get; set; }
        public string RegistrationDateRequestPaymentCheckPropertyRegistration { get; set; }
        public string RegistrationTimeRequestPaymentCheckPropertyRegistration { get; set; }
        public string AuditStatusRequestPaymentCheckPropertyRegistration { get; set; }
        public string InstanceIdRequestPaymentCheckPropertyRegistration { get; set; }
        public int? InstanceSridRequestPaymentCheckPropertyRegistration { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
