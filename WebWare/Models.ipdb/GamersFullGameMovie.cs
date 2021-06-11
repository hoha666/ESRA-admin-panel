using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class GamersFullGameMovie
    {
        public int Id { get; set; }
        public string TxaTozih { get; set; }
        public string UplFilm { get; set; }
        public string CreatorGamersFullGameMovie { get; set; }
        public string IpGamersFullGameMovie { get; set; }
        public bool? RegistrationStatusGamersFullGameMovie { get; set; }
        public string RegistrationDateGamersFullGameMovie { get; set; }
        public string RegistrationTimeGamersFullGameMovie { get; set; }
        public string AuditStatusGamersFullGameMovie { get; set; }
        public string InstanceIdGamersFullGameMovie { get; set; }
        public int? InstanceSridGamersFullGameMovie { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }

        public GamersFullMovie2 ParentRecord { get; set; }
    }
}
