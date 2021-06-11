using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class ContentScore
    {
        public int Id { get; set; }
        public string CreatorContentScore { get; set; }
        public string IpContentScore { get; set; }
        public bool? RegistrationStatusContentScore { get; set; }
        public string RegistrationDateContentScore { get; set; }
        public string RegistrationTimeContentScore { get; set; }
        public string AuditStatusContentScore { get; set; }
        public string InstanceIdContentScore { get; set; }
        public string GameGenre { get; set; }
        public string SpeedOfAct { get; set; }
        public string GameSpan { get; set; }
        public string GamerComment { get; set; }
        public string NeedEnglish { get; set; }
        public string Fear { get; set; }
        public string Violence { get; set; }
        public string Anomalies { get; set; }
        public string Tobacco { get; set; }
        public string Disappointment { get; set; }
        public int? InstanceSridContentScore { get; set; }
    }
}
