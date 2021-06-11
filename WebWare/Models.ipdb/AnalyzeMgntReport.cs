using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class AnalyzeMgntReport
    {
        public int Id { get; set; }
        public string TxaComment { get; set; }
        public string CreatorAnalyzeMgntReport { get; set; }
        public string IpAnalyzeMgntReport { get; set; }
        public bool? RegistrationStatusAnalyzeMgntReport { get; set; }
        public string RegistrationDateAnalyzeMgntReport { get; set; }
        public string RegistrationTimeAnalyzeMgntReport { get; set; }
        public string AuditStatusAnalyzeMgntReport { get; set; }
        public string InstanceIdAnalyzeMgntReport { get; set; }
        public int? InstanceSridAnalyzeMgntReport { get; set; }
    }
}
