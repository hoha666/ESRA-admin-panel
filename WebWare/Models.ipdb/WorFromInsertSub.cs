using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class WorFromInsertSub
    {
        public int Id { get; set; }
        public string TxtFormName { get; set; }
        public string TxtDbformName { get; set; }
        public string TxtDescription { get; set; }
        public string CreatorWorFromInsertSub { get; set; }
        public string IpWorFromInsertSub { get; set; }
        public bool? RegistrationStatusWorFromInsertSub { get; set; }
        public string RegistrationDateWorFromInsertSub { get; set; }
        public string RegistrationTimeWorFromInsertSub { get; set; }
        public string AuditStatusWorFromInsertSub { get; set; }
        public string InstanceIdWorFromInsertSub { get; set; }
        public int? InstanceSridWorFromInsertSub { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }

        public WorkFlowFormInsertion ParentRecord { get; set; }
    }
}
