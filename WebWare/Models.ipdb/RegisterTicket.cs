using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RegisterTicket
    {
        public int Id { get; set; }
        public string CreatorRegisterTicket { get; set; }
        public string IpRegisterTicket { get; set; }
        public bool? RegistrationStatusRegisterTicket { get; set; }
        public string RegistrationDateRegisterTicket { get; set; }
        public string RegistrationTimeRegisterTicket { get; set; }
        public string AuditStatusRegisterTicket { get; set; }
        public string InstanceIdRegisterTicket { get; set; }
        public int? InstanceSridRegisterTicket { get; set; }
        public string DdlCategory { get; set; }
        public string TxtSubject { get; set; }
        public string TxtSharh { get; set; }
        public string FileUpl { get; set; }
    }
}
