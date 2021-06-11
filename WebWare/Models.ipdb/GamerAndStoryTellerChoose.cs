using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class GamerAndStoryTellerChoose
    {
        public GamerAndStoryTellerChoose()
        {
            AnotherRatings = new HashSet<AnotherRatings>();
        }

        public int Id { get; set; }
        public string DdlGamerSelect { get; set; }
        public string TxtStoryTellerSelect { get; set; }
        public string CreatorGamerAndStoryTellerChoose { get; set; }
        public string IpGamerAndStoryTellerChoose { get; set; }
        public bool? RegistrationStatusGamerAndStoryTellerChoose { get; set; }
        public string RegistrationDateGamerAndStoryTellerChoose { get; set; }
        public string RegistrationTimeGamerAndStoryTellerChoose { get; set; }
        public string AuditStatusGamerAndStoryTellerChoose { get; set; }
        public string InstanceIdGamerAndStoryTellerChoose { get; set; }
        public int? InstanceSridGamerAndStoryTellerChoose { get; set; }

        public ICollection<AnotherRatings> AnotherRatings { get; set; }
    }
}
