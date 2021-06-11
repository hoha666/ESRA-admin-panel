using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class LegalDocUpload
    {
        public int Id { get; set; }
        public string AgentNcardPic { get; set; }
        public string AgentBcpic { get; set; }
        public string OfficialNewspaper { get; set; }
        public string MgntChangePic { get; set; }
        public string CompanyResume { get; set; }
        public string CreatorLegalDocUpload { get; set; }
        public string IpLegalDocUpload { get; set; }
        public bool? RegistrationStatusLegalDocUpload { get; set; }
        public string RegistrationDateLegalDocUpload { get; set; }
        public string RegistrationTimeLegalDocUpload { get; set; }
        public string AuditStatusLegalDocUpload { get; set; }
        public string InstanceIdLegalDocUpload { get; set; }
        public int? InstanceSridLegalDocUpload { get; set; }
        public string TxaComment { get; set; }
    }
}
