using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class GamersFullMovie2
    {
        public GamersFullMovie2()
        {
            GamersFullGameMovie = new HashSet<GamersFullGameMovie>();
        }

        public int Id { get; set; }
        public string CreatorGamersFullMovie2 { get; set; }
        public string IpGamersFullMovie2 { get; set; }
        public bool? RegistrationStatusGamersFullMovie2 { get; set; }
        public string RegistrationDateGamersFullMovie2 { get; set; }
        public string RegistrationTimeGamersFullMovie2 { get; set; }
        public string AuditStatusGamersFullMovie2 { get; set; }
        public string InstanceIdGamersFullMovie2 { get; set; }
        public int? InstanceSridGamersFullMovie2 { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }

        public ICollection<GamersFullGameMovie> GamersFullGameMovie { get; set; }
    }
}
