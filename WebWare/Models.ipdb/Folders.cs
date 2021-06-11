using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class Folders
    {
        public int Id { get; set; }
        public string CartableId { get; set; }
        public string Name { get; set; }
        public string ParentId { get; set; }
    }
}
