using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblAuctionItemDisable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public int State { get; set; }
        public int ExclusiveYears { get; set; }
        public int ExclusiveTypeId { get; set; }
    }
}
