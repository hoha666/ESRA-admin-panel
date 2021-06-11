using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class ContentScoreAverage
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public int InstanceId { get; set; }
        public int GameSkills { get; set; }
        public int Fear { get; set; }
        public int Violence { get; set; }
        public int Anomalies { get; set; }
        public int Tobacco { get; set; }
        public int Disappointment { get; set; }
    }
}
