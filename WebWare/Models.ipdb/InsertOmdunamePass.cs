using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class InsertOmdunamePass
    {
        public int Id { get; set; }
        public string TxtUname { get; set; }
        public string TxtPass { get; set; }
        public string CreatorInsertOmdunamePass { get; set; }
        public string IpInsertOmdunamePass { get; set; }
        public bool? RegistrationStatusInsertOmdunamePass { get; set; }
        public string RegistrationDateInsertOmdunamePass { get; set; }
        public string RegistrationTimeInsertOmdunamePass { get; set; }
        public string AuditStatusInsertOmdunamePass { get; set; }
        public string InstanceIdInsertOmdunamePass { get; set; }
        public int? InstanceSridInsertOmdunamePass { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
