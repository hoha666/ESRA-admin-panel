using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class PersonFolders
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ParentId { get; set; }
    }
}
