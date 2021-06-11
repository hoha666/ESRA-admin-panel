using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class FormGroups
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Type { get; set; }
        public int Root { get; set; }
    }
}
