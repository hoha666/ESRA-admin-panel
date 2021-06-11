using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class ReportTblOnlineContestLicenses
    {
        public int Id { get; set; }
        public string LicenseNumber { get; set; }
        public string IssueDate { get; set; }
        public string RequestDate { get; set; }
        public string CompanyName { get; set; }
        public string GameName { get; set; }
        public string ContestStartDate { get; set; }
        public string ContestEndDate { get; set; }
        public string ContestAddress { get; set; }
    }
}
