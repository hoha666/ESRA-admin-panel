using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class WorkflowAnalysePrimaryDocs
    {
        public int Id { get; set; }
        public string TxtName { get; set; }
        public string TxtCode { get; set; }
        public string UplDocs { get; set; }
        public string TxtOwner { get; set; }
        public string UplConfirmation { get; set; }
        public string RadPrority { get; set; }
        public string CreatorWorkflowAnalysePrimaryDocs { get; set; }
        public string IpWorkflowAnalysePrimaryDocs { get; set; }
        public bool? RegistrationStatusWorkflowAnalysePrimaryDocs { get; set; }
        public string RegistrationDateWorkflowAnalysePrimaryDocs { get; set; }
        public string RegistrationTimeWorkflowAnalysePrimaryDocs { get; set; }
        public string AuditStatusWorkflowAnalysePrimaryDocs { get; set; }
        public string InstanceIdWorkflowAnalysePrimaryDocs { get; set; }
        public int? InstanceSridWorkflowAnalysePrimaryDocs { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
