using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class NarratorReport
    {
        public int Id { get; set; }
        public string DdlIsnarrating { get; set; }
        public string TxaGameStoryAbs { get; set; }
        public string TxaGameStory { get; set; }
        public string CreatorNarratorReport { get; set; }
        public string IpNarratorReport { get; set; }
        public bool? RegistrationStatusNarratorReport { get; set; }
        public string RegistrationDateNarratorReport { get; set; }
        public string RegistrationTimeNarratorReport { get; set; }
        public string AuditStatusNarratorReport { get; set; }
        public string InstanceIdNarratorReport { get; set; }
        public int? InstanceSridNarratorReport { get; set; }
        public string Metacritic { get; set; }
    }
}
