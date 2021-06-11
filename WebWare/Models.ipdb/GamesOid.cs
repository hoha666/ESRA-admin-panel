using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class GamesOid
    {
        public int Id { get; set; }
        public string Version { get; set; }
        public string Genre { get; set; }
        public string Plot { get; set; }
        public DateTime ProductionDate { get; set; }
        public string Company { get; set; }
        public bool DownloadableSource { get; set; }
        public string SourceUrl { get; set; }
        public string Gid { get; set; }
        public string Iid { get; set; }
        public string Oid { get; set; }
    }
}
