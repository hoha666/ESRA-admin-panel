using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class ReportTblSingleUseInstitutes
    {
        public int Id { get; set; }
        public string LicenseNumber { get; set; }
        public string IssueDate { get; set; }
        public string ValidPeriod { get; set; }
        public string InstituteStatuteNumber { get; set; }
        public string InstituteRegistrationDate { get; set; }
        public string InstituteName { get; set; }
        public string DirectorResponsibleFname { get; set; }
        public string DirectorResponsibleLname { get; set; }
        public string InstituteAddress { get; set; }
    }
}
