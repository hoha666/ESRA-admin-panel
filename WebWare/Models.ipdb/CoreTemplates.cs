using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class CoreTemplates
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public bool IsActive { get; set; }
        public bool IsInstalled { get; set; }
    }
}
