using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class GreenHologramRequestReview
    {
        public int Id { get; set; }
        public string DdlResultReview { get; set; }
        public string CreatorGreenHologramRequestReview { get; set; }
        public string IpGreenHologramRequestReview { get; set; }
        public bool? RegistrationStatusGreenHologramRequestReview { get; set; }
        public string RegistrationDateGreenHologramRequestReview { get; set; }
        public string RegistrationTimeGreenHologramRequestReview { get; set; }
        public string AuditStatusGreenHologramRequestReview { get; set; }
        public string InstanceIdGreenHologramRequestReview { get; set; }
        public int? InstanceSridGreenHologramRequestReview { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
