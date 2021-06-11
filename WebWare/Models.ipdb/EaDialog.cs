using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class EaDialog
    {
        public int Id { get; set; }
        public string TxtWorkflowName { get; set; }
        public string TxtCode { get; set; }
        public string FileAnalyseDoc { get; set; }
        public string FileConfirmDoc { get; set; }
        public string FileDataModelDoc { get; set; }
        public string CreatorEaDialog { get; set; }
        public string IpEaDialog { get; set; }
        public bool? RegistrationStatusEaDialog { get; set; }
        public string RegistrationDateEaDialog { get; set; }
        public string RegistrationTimeEaDialog { get; set; }
        public string AuditStatusEaDialog { get; set; }
        public string InstanceIdEaDialog { get; set; }
        public int? InstanceSridEaDialog { get; set; }
    }
}
