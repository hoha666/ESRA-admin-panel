using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class ProcessChangeRequest
    {
        public int Id { get; set; }
        public string TxtTitle { get; set; }
        public string TxtPt { get; set; }
        public string TxtD { get; set; }
        public string TxtOffer { get; set; }
        public string CreatorProcessChangeRequest { get; set; }
        public string IpProcessChangeRequest { get; set; }
        public bool? RegistrationStatusProcessChangeRequest { get; set; }
        public string RegistrationDateProcessChangeRequest { get; set; }
        public string RegistrationTimeProcessChangeRequest { get; set; }
        public string AuditStatusProcessChangeRequest { get; set; }
        public string InstanceIdProcessChangeRequest { get; set; }
        public int? InstanceSridProcessChangeRequest { get; set; }
    }
}
