using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class LegalPersonRegistrationRecordAllDocuments
    {
        public int Id { get; set; }
        public string DdlStatusReceivedForm { get; set; }
        public string CkeDescription { get; set; }
        public string CreatorLegalPersonRegistrationRecordAllDocuments { get; set; }
        public string IpLegalPersonRegistrationRecordAllDocuments { get; set; }
        public bool? RegistrationStatusLegalPersonRegistrationRecordAllDocuments { get; set; }
        public string RegistrationDateLegalPersonRegistrationRecordAllDocuments { get; set; }
        public string RegistrationTimeLegalPersonRegistrationRecordAllDocuments { get; set; }
        public string AuditStatusLegalPersonRegistrationRecordAllDocuments { get; set; }
        public string InstanceIdLegalPersonRegistrationRecordAllDocuments { get; set; }
        public int? InstanceSridLegalPersonRegistrationRecordAllDocuments { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
