using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class GamesIid
    {
        public int Id { get; set; }
        public string IsEditable { get; set; }
        public string Platform { get; set; }
        public string IsOriginal { get; set; }
        public string Gid { get; set; }
        public string Iid { get; set; }
    }
}
