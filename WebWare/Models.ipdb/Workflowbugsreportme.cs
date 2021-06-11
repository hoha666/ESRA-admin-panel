using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class Workflowbugsreportme
    {
        public int Id { get; set; }
        public string CkWfreport { get; set; }
        public string CreatorWorkflowbugsreportme { get; set; }
        public string IpWorkflowbugsreportme { get; set; }
        public bool? RegistrationStatusWorkflowbugsreportme { get; set; }
        public string RegistrationDateWorkflowbugsreportme { get; set; }
        public string RegistrationTimeWorkflowbugsreportme { get; set; }
        public string AuditStatusWorkflowbugsreportme { get; set; }
        public string InstanceIdWorkflowbugsreportme { get; set; }
        public int? InstanceSridWorkflowbugsreportme { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
