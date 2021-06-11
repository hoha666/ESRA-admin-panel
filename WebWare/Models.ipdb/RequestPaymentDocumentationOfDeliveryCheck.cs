using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RequestPaymentDocumentationOfDeliveryCheck
    {
        public int Id { get; set; }
        public string UplSignedReceiptImage { get; set; }
        public string AxtDescription { get; set; }
        public string CreatorRequestPaymentDocumentationOfDeliveryCheck { get; set; }
        public string IpRequestPaymentDocumentationOfDeliveryCheck { get; set; }
        public bool? RegistrationStatusRequestPaymentDocumentationOfDeliveryCheck { get; set; }
        public string RegistrationDateRequestPaymentDocumentationOfDeliveryCheck { get; set; }
        public string RegistrationTimeRequestPaymentDocumentationOfDeliveryCheck { get; set; }
        public string AuditStatusRequestPaymentDocumentationOfDeliveryCheck { get; set; }
        public string InstanceIdRequestPaymentDocumentationOfDeliveryCheck { get; set; }
        public int? InstanceSridRequestPaymentDocumentationOfDeliveryCheck { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
