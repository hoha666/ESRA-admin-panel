using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class ReportTblSupplyLicenses
    {
        public int Id { get; set; }
        public string LicenseNumber { get; set; }
        public string IssueDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FathersName { get; set; }
        public string NationalId { get; set; }
        public string BirthCertificateCity { get; set; }
        public string Location { get; set; }
        public string CompanyName { get; set; }
    }
}
