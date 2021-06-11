using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class AdminPageBlocks
    {
        public int Id { get; set; }
        public int PageId { get; set; }
        public int BlockId { get; set; }
        public int AppearanceOrder { get; set; }
        public string OptionId { get; set; }
    }
}
