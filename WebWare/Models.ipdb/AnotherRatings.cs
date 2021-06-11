using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class AnotherRatings
    {
        public int Id { get; set; }
        public string DdlNezam { get; set; }
        public string DdlRadeh { get; set; }
        public string CreatorAnotherRatings { get; set; }
        public string IpAnotherRatings { get; set; }
        public bool? RegistrationStatusAnotherRatings { get; set; }
        public string RegistrationDateAnotherRatings { get; set; }
        public string RegistrationTimeAnotherRatings { get; set; }
        public string AuditStatusAnotherRatings { get; set; }
        public string InstanceIdAnotherRatings { get; set; }
        public int? InstanceSridAnotherRatings { get; set; }
        public string TxaTozih { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }

        public GamerAndStoryTellerChoose ParentRecord { get; set; }
    }
}
