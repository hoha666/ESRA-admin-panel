using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class Smspanels
    {
        public int Id { get; set; }
        public string Apikey { get; set; }
        public string SenderTel { get; set; }
        public string LocalId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Isdefault { get; set; }
    }
}
