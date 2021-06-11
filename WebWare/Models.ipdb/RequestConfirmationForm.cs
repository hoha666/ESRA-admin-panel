using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RequestConfirmationForm
    {
        public int Id { get; set; }
        public string Result { get; set; }
        public string Comment { get; set; }
        public string CreatorRequestConfirmationForm { get; set; }
        public string IpRequestConfirmationForm { get; set; }
        public bool? RegistrationStatusRequestConfirmationForm { get; set; }
        public string RegistrationDateRequestConfirmationForm { get; set; }
        public string RegistrationTimeRequestConfirmationForm { get; set; }
        public string AuditStatusRequestConfirmationForm { get; set; }
        public string InstanceIdRequestConfirmationForm { get; set; }
        public int? InstanceSridRequestConfirmationForm { get; set; }
    }
}
