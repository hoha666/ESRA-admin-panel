using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class OtherRatings
    {
        public int Id { get; set; }
        public string DdlSystemRating { get; set; }
        public string Ddl2Raing { get; set; }
        public string TxaGameContex { get; set; }
        public string CreatorOtherRatings { get; set; }
        public string IpOtherRatings { get; set; }
        public bool? RegistrationStatusOtherRatings { get; set; }
        public string RegistrationDateOtherRatings { get; set; }
        public string RegistrationTimeOtherRatings { get; set; }
        public string AuditStatusOtherRatings { get; set; }
        public string InstanceIdOtherRatings { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
        public int? InstanceSridOtherRatings { get; set; }

        public GameInformation ParentRecord { get; set; }
    }
}
