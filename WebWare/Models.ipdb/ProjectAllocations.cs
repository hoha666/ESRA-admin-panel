using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class ProjectAllocations
    {
        public int Id { get; set; }
        public string ProjectCode { get; set; }
        public int PersonNationalCode { get; set; }
        public string PersonPost { get; set; }
    }
}
