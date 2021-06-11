using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class GameStoryForm
    {
        public int Id { get; set; }
        public string TxaChekide { get; set; }
        public string TxaFull { get; set; }
        public string CreatorGameStoryForm { get; set; }
        public string IpGameStoryForm { get; set; }
        public bool? RegistrationStatusGameStoryForm { get; set; }
        public string RegistrationDateGameStoryForm { get; set; }
        public string RegistrationTimeGameStoryForm { get; set; }
        public string AuditStatusGameStoryForm { get; set; }
        public string InstanceIdGameStoryForm { get; set; }
        public int? InstanceSridGameStoryForm { get; set; }
    }
}
