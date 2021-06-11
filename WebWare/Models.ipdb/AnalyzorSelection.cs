using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class AnalyzorSelection
    {
        public int Id { get; set; }
        public string DdlAnalyzor { get; set; }
        public string CreatorAnalyzorSelection { get; set; }
        public string IpAnalyzorSelection { get; set; }
        public bool? RegistrationStatusAnalyzorSelection { get; set; }
        public string RegistrationDateAnalyzorSelection { get; set; }
        public string RegistrationTimeAnalyzorSelection { get; set; }
        public string AuditStatusAnalyzorSelection { get; set; }
        public string InstanceIdAnalyzorSelection { get; set; }
        public int? InstanceSridAnalyzorSelection { get; set; }
        public string DdlResult { get; set; }
    }
}
