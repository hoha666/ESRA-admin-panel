using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class SurGameType
    {
        public int Id { get; set; }
        public string TxtTitle { get; set; }
        public string DdlGameType { get; set; }
        public string CreatorSurGameType { get; set; }
        public string IpSurGameType { get; set; }
        public bool? RegistrationStatusSurGameType { get; set; }
        public string RegistrationDateSurGameType { get; set; }
        public string RegistrationTimeSurGameType { get; set; }
        public string AuditStatusSurGameType { get; set; }
        public string InstanceIdSurGameType { get; set; }
        public int? InstanceSridSurGameType { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
