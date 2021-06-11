using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class SystemPages
    {
        public int Id { get; set; }
        public string PageName { get; set; }
        public string PageTitle { get; set; }
        public string Description { get; set; }
        public string PageContent { get; set; }
        public int AppOrder { get; set; }
        public bool ShowInMenu { get; set; }
    }
}
