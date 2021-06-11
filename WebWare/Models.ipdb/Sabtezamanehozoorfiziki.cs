using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class Sabtezamanehozoorfiziki
    {
        public int Id { get; set; }
        public string TxaZaman { get; set; }
        public string CreatorSabtezamanehozoorfiziki { get; set; }
        public string IpSabtezamanehozoorfiziki { get; set; }
        public bool? RegistrationStatusSabtezamanehozoorfiziki { get; set; }
        public string RegistrationDateSabtezamanehozoorfiziki { get; set; }
        public string RegistrationTimeSabtezamanehozoorfiziki { get; set; }
        public string AuditStatusSabtezamanehozoorfiziki { get; set; }
        public string InstanceIdSabtezamanehozoorfiziki { get; set; }
        public int? InstanceSridSabtezamanehozoorfiziki { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
