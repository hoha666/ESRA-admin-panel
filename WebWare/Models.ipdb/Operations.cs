using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class Operations
    {
        public int Id { get; set; }
        public int LawId { get; set; }
        public string Action { get; set; }
        public int Field { get; set; }

        public Laws Law { get; set; }
    }
}
