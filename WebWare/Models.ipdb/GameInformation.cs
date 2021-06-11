using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class GameInformation
    {
        public GameInformation()
        {
            GamePlatform = new HashSet<GamePlatform>();
            OtherRatings = new HashSet<OtherRatings>();
            SourceMedia = new HashSet<SourceMedia>();
        }

        public int Id { get; set; }
        public string CreatorGameInformation { get; set; }
        public string IpGameInformation { get; set; }
        public bool? RegistrationStatusGameInformation { get; set; }
        public string RegistrationDateGameInformation { get; set; }
        public string RegistrationTimeGameInformation { get; set; }
        public string AuditStatusGameInformation { get; set; }
        public string InstanceIdGameInformation { get; set; }
        public int? InstanceSridGameInformation { get; set; }
        public string Gamer { get; set; }
        public string Narrator { get; set; }

        public ICollection<GamePlatform> GamePlatform { get; set; }
        public ICollection<OtherRatings> OtherRatings { get; set; }
        public ICollection<SourceMedia> SourceMedia { get; set; }
    }
}
