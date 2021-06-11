using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class GamerChooseAgain
    {
        public int Id { get; set; }
        public string DdlGamer { get; set; }
        public string CreatorGamerChooseAgain { get; set; }
        public string IpGamerChooseAgain { get; set; }
        public bool? RegistrationStatusGamerChooseAgain { get; set; }
        public string RegistrationDateGamerChooseAgain { get; set; }
        public string RegistrationTimeGamerChooseAgain { get; set; }
        public string AuditStatusGamerChooseAgain { get; set; }
        public string InstanceIdGamerChooseAgain { get; set; }
        public int? InstanceSridGamerChooseAgain { get; set; }
    }
}
