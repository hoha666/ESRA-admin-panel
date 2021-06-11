using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class Esra2RequestRegister
    {
        public int Id { get; set; }
        public string TxtTitle { get; set; }
        public string CreatorEsra2RequestRegister { get; set; }
        public string IpEsra2RequestRegister { get; set; }
        public bool? RegistrationStatusEsra2RequestRegister { get; set; }
        public string RegistrationDateEsra2RequestRegister { get; set; }
        public string RegistrationTimeEsra2RequestRegister { get; set; }
        public string AuditStatusEsra2RequestRegister { get; set; }
        public string InstanceIdEsra2RequestRegister { get; set; }
        public int? InstanceSridEsra2RequestRegister { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
