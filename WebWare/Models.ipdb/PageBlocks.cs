using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class PageBlocks
    {
        public int Id { get; set; }
        public int PageId { get; set; }
        public int BlockId { get; set; }
        public string ZoneName { get; set; }
        public int AppearanceOrder { get; set; }
        public string OptionId { get; set; }
    }
}
