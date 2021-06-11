using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class WfProgressDetails
    {
        public int Id { get; set; }
        public int WfProgressId { get; set; }
        public bool ShowDetail { get; set; }
        public string FormsId { get; set; }
        public int RoleId { get; set; }
        public int? WorkFlowProgressId { get; set; }

        public WorkFlowProgresses WorkFlowProgress { get; set; }
    }
}
