using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class DescriptionForm
    {
        public int Id { get; set; }
        public string TxaDescription { get; set; }
        public string CreatorDescriptionForm { get; set; }
        public string IpDescriptionForm { get; set; }
        public bool? RegistrationStatusDescriptionForm { get; set; }
        public string RegistrationDateDescriptionForm { get; set; }
        public string RegistrationTimeDescriptionForm { get; set; }
        public string AuditStatusDescriptionForm { get; set; }
        public string InstanceIdDescriptionForm { get; set; }
        public int? InstanceSridDescriptionForm { get; set; }
    }
}
