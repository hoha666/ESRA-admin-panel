using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class AddLevel2
    {
        public AddLevel2()
        {
            RelationAddLevel2Test201808013 = new HashSet<RelationAddLevel2Test201808013>();
        }

        public int Id { get; set; }
        public string DdlLevel1 { get; set; }
        public string TxtLevel2 { get; set; }
        public string CreatorAddLevel2 { get; set; }
        public string IpAddLevel2 { get; set; }
        public bool? RegistrationStatusAddLevel2 { get; set; }
        public string RegistrationDateAddLevel2 { get; set; }
        public string RegistrationTimeAddLevel2 { get; set; }
        public string AuditStatusAddLevel2 { get; set; }
        public string InstanceIdAddLevel2 { get; set; }
        public int? InstanceSridAddLevel2 { get; set; }

        public ICollection<RelationAddLevel2Test201808013> RelationAddLevel2Test201808013 { get; set; }
    }
}
