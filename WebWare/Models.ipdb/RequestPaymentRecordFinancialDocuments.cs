using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RequestPaymentRecordFinancialDocuments
    {
        public int Id { get; set; }
        public string UplOrderConfirmedPayment { get; set; }
        public string UplCheckedSignatureImage { get; set; }
        public string AxtDescription { get; set; }
        public string CreatorRequestPaymentRecordFinancialDocuments { get; set; }
        public string IpRequestPaymentRecordFinancialDocuments { get; set; }
        public bool? RegistrationStatusRequestPaymentRecordFinancialDocuments { get; set; }
        public string RegistrationDateRequestPaymentRecordFinancialDocuments { get; set; }
        public string RegistrationTimeRequestPaymentRecordFinancialDocuments { get; set; }
        public string AuditStatusRequestPaymentRecordFinancialDocuments { get; set; }
        public string InstanceIdRequestPaymentRecordFinancialDocuments { get; set; }
        public int? InstanceSridRequestPaymentRecordFinancialDocuments { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
