using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class NezaratOw
    {
        public int Id { get; set; }
        public string TxaNazarO { get; set; }
        public string CreatorNezaratOw { get; set; }
        public string IpNezaratOw { get; set; }
        public bool? RegistrationStatusNezaratOw { get; set; }
        public string RegistrationDateNezaratOw { get; set; }
        public string RegistrationTimeNezaratOw { get; set; }
        public string AuditStatusNezaratOw { get; set; }
        public string InstanceIdNezaratOw { get; set; }
        public int? InstanceSridNezaratOw { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
