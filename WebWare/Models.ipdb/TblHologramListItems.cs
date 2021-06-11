using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblHologramListItems
    {
        public int Id { get; set; }
        public int HologramListId { get; set; }
        public string LicenseNumber { get; set; }
        public int? RequestNumber { get; set; }
        public int? InstallNumber { get; set; }
        public string HologramNumStart { get; set; }
        public string HologramNumEnd { get; set; }
        public string Types { get; set; }
    }
}
