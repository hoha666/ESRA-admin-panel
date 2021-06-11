using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class Test201808013
    {
        public Test201808013()
        {
            RelationAddLevel2Test201808013 = new HashSet<RelationAddLevel2Test201808013>();
        }

        public int Id { get; set; }
        public string Txt1 { get; set; }
        public string Rtb1 { get; set; }
        public string CreatorTest201808013 { get; set; }
        public string IpTest201808013 { get; set; }
        public bool? RegistrationStatusTest201808013 { get; set; }
        public string RegistrationDateTest201808013 { get; set; }
        public string RegistrationTimeTest201808013 { get; set; }
        public string AuditStatusTest201808013 { get; set; }
        public string InstanceIdTest201808013 { get; set; }
        public int? InstanceSridTest201808013 { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }

        public ICollection<RelationAddLevel2Test201808013> RelationAddLevel2Test201808013 { get; set; }
    }
}
