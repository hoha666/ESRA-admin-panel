using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class WiDataModelSession
    {
        public int Id { get; set; }
        public string GdateSession { get; set; }
        public DateTime? GdateSessionGregorian { get; set; }
        public string UplDoc { get; set; }
        public string CreatorWiDataModelSession { get; set; }
        public string IpWiDataModelSession { get; set; }
        public bool? RegistrationStatusWiDataModelSession { get; set; }
        public string RegistrationDateWiDataModelSession { get; set; }
        public string RegistrationTimeWiDataModelSession { get; set; }
        public string AuditStatusWiDataModelSession { get; set; }
        public string InstanceIdWiDataModelSession { get; set; }
        public int? InstanceSridWiDataModelSession { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
