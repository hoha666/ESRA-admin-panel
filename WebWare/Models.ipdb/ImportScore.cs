using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class ImportScore
    {
        public int Id { get; set; }
        public string TxtScore { get; set; }
        public string CreatorImportScore { get; set; }
        public string IpImportScore { get; set; }
        public bool? RegistrationStatusImportScore { get; set; }
        public string RegistrationDateImportScore { get; set; }
        public string RegistrationTimeImportScore { get; set; }
        public string AuditStatusImportScore { get; set; }
        public string InstanceIdImportScore { get; set; }
        public int? InstanceSridImportScore { get; set; }
    }
}
