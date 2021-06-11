using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class ArtCulturalActivities
    {
        public int Id { get; set; }
        public string TxtActivityType { get; set; }
        public string TxtPost { get; set; }
        public string TxtWorkPlace { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string TxaDueToLeave { get; set; }
        public string CreatorArtCulturalActivities { get; set; }
        public string IpArtCulturalActivities { get; set; }
        public bool? RegistrationStatusArtCulturalActivities { get; set; }
        public string RegistrationDateArtCulturalActivities { get; set; }
        public string RegistrationTimeArtCulturalActivities { get; set; }
        public string AuditStatusArtCulturalActivities { get; set; }
        public string InstanceIdArtCulturalActivities { get; set; }
        public int? InstanceSridArtCulturalActivities { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }

        public InstitutionExecutivesProfile ParentRecord { get; set; }
    }
}
