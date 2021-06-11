using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblVersionEsra
    {
        public int Id { get; set; }
        public DateTime CreationDateTime { get; set; }
        public string EsraSummary { get; set; }
        public bool? ForEdit { get; set; }
        public int IdEsra { get; set; }
        public int? IdEsraStatus { get; set; }
        public int? IdEsraType { get; set; }
        public int? IdSystem { get; set; }
        public int IdUser { get; set; }
        public int IdVersion { get; set; }

        public TblEsra IdEsraNavigation { get; set; }
        public TblEsra IdSystemNavigation { get; set; }
        public TblVersion IdVersionNavigation { get; set; }
    }
}
