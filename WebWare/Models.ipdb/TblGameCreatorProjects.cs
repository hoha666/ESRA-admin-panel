using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblGameCreatorProjects
    {
        public int Id { get; set; }
        public int IdIndependentGameCreator { get; set; }
        public string Title { get; set; }
        public string Employer { get; set; }
        public string Responsibility { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int IdAreaActivity { get; set; }
        public string AreaActivityComment { get; set; }

        public TblAreaActivity IdAreaActivityNavigation { get; set; }
    }
}
