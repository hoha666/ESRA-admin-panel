using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RequestPaymentSubmitApplication
    {
        public int Id { get; set; }
        public long? NumAmountOfMoney { get; set; }
        public string TxtPaymentSubject { get; set; }
        public string UplPaymentDocumentation { get; set; }
        public string CreatorRequestPaymentSubmitApplication { get; set; }
        public string IpRequestPaymentSubmitApplication { get; set; }
        public bool? RegistrationStatusRequestPaymentSubmitApplication { get; set; }
        public string RegistrationDateRequestPaymentSubmitApplication { get; set; }
        public string RegistrationTimeRequestPaymentSubmitApplication { get; set; }
        public string AuditStatusRequestPaymentSubmitApplication { get; set; }
        public string InstanceIdRequestPaymentSubmitApplication { get; set; }
        public int? InstanceSridRequestPaymentSubmitApplication { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
