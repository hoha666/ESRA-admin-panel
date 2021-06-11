using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class ReportTblPhysicalPublishLicensesAuc
    {
        public int Id { get; set; }
        public string LicenseNumber { get; set; }
        public string StartDate { get; set; }
        public string SourceType { get; set; }
        public string GameTitle { get; set; }
        public string Os { get; set; }
        public string Format { get; set; }
        public string Count { get; set; }
        public string Age { get; set; }
        public string CompanyName { get; set; }
    }
}
