using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblHologramList
    {
        public int Id { get; set; }
        public DateTime RequestDate { get; set; }
        public DateTime? InstallDate { get; set; }
        public int PublisherId { get; set; }
    }
}
