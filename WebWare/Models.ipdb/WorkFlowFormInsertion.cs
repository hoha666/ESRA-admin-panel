using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class WorkFlowFormInsertion
    {
        public WorkFlowFormInsertion()
        {
            WorFromInsertSub = new HashSet<WorFromInsertSub>();
        }

        public int Id { get; set; }
        public string CreatorWorkFlowFormInsertion { get; set; }
        public string IpWorkFlowFormInsertion { get; set; }
        public bool? RegistrationStatusWorkFlowFormInsertion { get; set; }
        public string RegistrationDateWorkFlowFormInsertion { get; set; }
        public string RegistrationTimeWorkFlowFormInsertion { get; set; }
        public string AuditStatusWorkFlowFormInsertion { get; set; }
        public string InstanceIdWorkFlowFormInsertion { get; set; }
        public int? InstanceSridWorkFlowFormInsertion { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }

        public ICollection<WorFromInsertSub> WorFromInsertSub { get; set; }
    }
}
