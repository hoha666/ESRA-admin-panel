using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblIndicator
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public string Prefix { get; set; }

        public TblIndicator IdNavigation { get; set; }
        public TblIndicator InverseIdNavigation { get; set; }
    }
}
