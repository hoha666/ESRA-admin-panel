using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class GamePlatform
    {
        public int Id { get; set; }
        public string DdlGamePlatform { get; set; }
        public string CreatorGamePlatform { get; set; }
        public string IpGamePlatform { get; set; }
        public bool? RegistrationStatusGamePlatform { get; set; }
        public string RegistrationDateGamePlatform { get; set; }
        public string RegistrationTimeGamePlatform { get; set; }
        public string AuditStatusGamePlatform { get; set; }
        public string InstanceIdGamePlatform { get; set; }
        public string TxtSite { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
        public int? InstanceSridGamePlatform { get; set; }
        public string MediaType { get; set; }
        public string TxtNumber { get; set; }

        public GameInformation ParentRecord { get; set; }
    }
}
