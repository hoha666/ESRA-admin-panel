using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class OnlineMarketsUserRequest
    {
        public int Id { get; set; }
        public string TxtReqTitle { get; set; }
        public string TxtCompanyName { get; set; }
        public string TxtCode { get; set; }
        public string TxaAddress { get; set; }
        public string TxtPostalCode { get; set; }
        public string TxtPeygir { get; set; }
        public string EmailPaygirAsl { get; set; }
        public string UplMostanadat { get; set; }
        public string CreatorOnlineMarketsUserRequest { get; set; }
        public string IpOnlineMarketsUserRequest { get; set; }
        public bool? RegistrationStatusOnlineMarketsUserRequest { get; set; }
        public string RegistrationDateOnlineMarketsUserRequest { get; set; }
        public string RegistrationTimeOnlineMarketsUserRequest { get; set; }
        public string AuditStatusOnlineMarketsUserRequest { get; set; }
        public string InstanceIdOnlineMarketsUserRequest { get; set; }
        public int? InstanceSridOnlineMarketsUserRequest { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
        public string TxtMobilePeygir { get; set; }
        public string ChkTahod { get; set; }
    }
}
