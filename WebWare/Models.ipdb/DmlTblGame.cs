using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class DmlTblGame
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Name2 { get; set; }
        public DateTime? PublishDateTime { get; set; }
        public bool? IsOnline { get; set; }
        public string WebSite { get; set; }
        public int? IdProducer { get; set; }
    }
}
