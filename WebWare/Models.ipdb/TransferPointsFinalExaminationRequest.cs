using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TransferPointsFinalExaminationRequest
    {
        public int Id { get; set; }
        public string DdlResultReview { get; set; }
        public string AxtOrderFinancialActions { get; set; }
        public string AxtOrderActionsInternalSoftware { get; set; }
        public string AxtRefusedRequests { get; set; }
        public string CreatorTransferPointsFinalExaminationRequest { get; set; }
        public string IpTransferPointsFinalExaminationRequest { get; set; }
        public bool? RegistrationStatusTransferPointsFinalExaminationRequest { get; set; }
        public string RegistrationDateTransferPointsFinalExaminationRequest { get; set; }
        public string RegistrationTimeTransferPointsFinalExaminationRequest { get; set; }
        public string AuditStatusTransferPointsFinalExaminationRequest { get; set; }
        public string InstanceIdTransferPointsFinalExaminationRequest { get; set; }
        public int? InstanceSridTransferPointsFinalExaminationRequest { get; set; }
    }
}
