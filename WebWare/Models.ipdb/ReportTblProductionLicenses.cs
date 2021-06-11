using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class ReportTblProductionLicenses
    {
        public int Id { get; set; }
        public string ProductionLicense { get; set; }
        public string StartDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FathersName { get; set; }
        public string NationalId { get; set; }
        public string BirthCertificateCity { get; set; }
        public string Location { get; set; }
        public string CompanyName { get; set; }
    }
}
