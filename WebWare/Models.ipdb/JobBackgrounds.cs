using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class JobBackgrounds
    {
        public int Id { get; set; }
        public string FileId { get; set; }
        public string CompanyName { get; set; }
        public string Startdate { get; set; }
        public string EndDate { get; set; }
        public string DurationOfActivity { get; set; }
        public string FieldOfCompanyActivity { get; set; }
        public string Post { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string RelevantSupervisor { get; set; }
        public int PersonId { get; set; }

        public People Person { get; set; }
    }
}
