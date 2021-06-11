using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class GamerCheckSource
    {
        public int Id { get; set; }
        public string TxaGameProcess { get; set; }
        public string DdlPerspective { get; set; }
        public string TxaDescription { get; set; }
        public string DdlError { get; set; }
        public string CreatorGamerCheckSource { get; set; }
        public string IpGamerCheckSource { get; set; }
        public bool? RegistrationStatusGamerCheckSource { get; set; }
        public string RegistrationDateGamerCheckSource { get; set; }
        public string RegistrationTimeGamerCheckSource { get; set; }
        public string AuditStatusGamerCheckSource { get; set; }
        public string InstanceIdGamerCheckSource { get; set; }
        public int? InstanceSridGamerCheckSource { get; set; }
        public string TxtPlayTime { get; set; }
        public string DdlHealth { get; set; }
    }
}
