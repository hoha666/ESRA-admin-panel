using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class GamerReport
    {
        public int Id { get; set; }
        public string DdlIsSource { get; set; }
        public string TxaComment { get; set; }
        public string TimeGameDuration { get; set; }
        public string TxaGameGoal { get; set; }
        public string CreatorGamerReport { get; set; }
        public string IpGamerReport { get; set; }
        public bool? RegistrationStatusGamerReport { get; set; }
        public string RegistrationDateGamerReport { get; set; }
        public string RegistrationTimeGamerReport { get; set; }
        public string AuditStatusGamerReport { get; set; }
        public string InstanceIdGamerReport { get; set; }
        public string DdlGameVangel { get; set; }
        public string DdlCause { get; set; }
        public int? InstanceSridGamerReport { get; set; }
        public string PicUpload { get; set; }
        public string DdlGameSkills { get; set; }
    }
}
