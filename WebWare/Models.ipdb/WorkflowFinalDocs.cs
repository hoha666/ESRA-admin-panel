using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class WorkflowFinalDocs
    {
        public int Id { get; set; }
        public string UplFinalDocs { get; set; }
        public string UplC1 { get; set; }
        public string UplC2 { get; set; }
        public string CreatorWorkflowFinalDocs { get; set; }
        public string IpWorkflowFinalDocs { get; set; }
        public bool? RegistrationStatusWorkflowFinalDocs { get; set; }
        public string RegistrationDateWorkflowFinalDocs { get; set; }
        public string RegistrationTimeWorkflowFinalDocs { get; set; }
        public string AuditStatusWorkflowFinalDocs { get; set; }
        public string InstanceIdWorkflowFinalDocs { get; set; }
        public int? InstanceSridWorkflowFinalDocs { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
