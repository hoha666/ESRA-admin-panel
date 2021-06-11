using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblTag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int IdNews { get; set; }

        public TblStaticPage IdNewsNavigation { get; set; }
    }
}
