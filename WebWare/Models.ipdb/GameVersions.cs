using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class GameVersions
    {
        public int Id { get; set; }
        public string Iid { get; set; }
        public string SpecialName { get; set; }
        public string Developer { get; set; }
        public DateTime DevelopeDate { get; set; }
        public string SourceAddress { get; set; }
        public string Oid { get; set; }
    }
}
