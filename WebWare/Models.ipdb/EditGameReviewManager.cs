using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class EditGameReviewManager
    {
        public int Id { get; set; }
        public string DdlResultOfReview { get; set; }
        public string AxtCorrectiveAnnouncement { get; set; }
        public string TxtSetAgeRating { get; set; }
        public int? NumPositiveScoreediting { get; set; }
        public int? NumnegativeScoreEditing { get; set; }
        public string AxtDescription { get; set; }
        public string CreatorEditGameReviewManager { get; set; }
        public string IpEditGameReviewManager { get; set; }
        public bool? RegistrationStatusEditGameReviewManager { get; set; }
        public string RegistrationDateEditGameReviewManager { get; set; }
        public string RegistrationTimeEditGameReviewManager { get; set; }
        public string AuditStatusEditGameReviewManager { get; set; }
        public string InstanceIdEditGameReviewManager { get; set; }
        public int? InstanceSridEditGameReviewManager { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
