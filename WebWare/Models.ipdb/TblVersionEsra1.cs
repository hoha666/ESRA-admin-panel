using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblVersionEsra1
    {
        public int Id { get; set; }
        public int IdVersion { get; set; }
        public int IdUser { get; set; }
        public int IdEsra { get; set; }
        public string EsraSummary { get; set; }
        public int? IdEsraType { get; set; }
        public int? IdSystem { get; set; }
        public DateTime CreationDateTime { get; set; }
        public int? IdEsraStatus { get; set; }
        public bool? ForEdit { get; set; }

        public TblEsra1 IdEsraNavigation { get; set; }
        public TblEsraStatus IdEsraStatusNavigation { get; set; }
        public TblEsraType IdEsraTypeNavigation { get; set; }
        public TblEsra1 IdSystemNavigation { get; set; }
        public TblProducerNexclusiveNuser IdUserNavigation { get; set; }
        public TblVersion1 IdVersionNavigation { get; set; }
    }
}
