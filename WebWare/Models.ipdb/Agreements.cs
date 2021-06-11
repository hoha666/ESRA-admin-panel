using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class Agreements
    {
        public int Id { get; set; }
        public string AgreementFile { get; set; }
        public string AgreementId { get; set; }
        public string ContractorName { get; set; }
        public string ContractorId { get; set; }
        public string AgreementDate { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string AgreementTitle { get; set; }
    }
}
