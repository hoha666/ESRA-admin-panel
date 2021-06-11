using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class EditGamePublisherReview
    {
        public int Id { get; set; }
        public string DdlResultOfReview { get; set; }
        public string CreatorEditGamePublisherReview { get; set; }
        public string IpEditGamePublisherReview { get; set; }
        public bool? RegistrationStatusEditGamePublisherReview { get; set; }
        public string RegistrationDateEditGamePublisherReview { get; set; }
        public string RegistrationTimeEditGamePublisherReview { get; set; }
        public string AuditStatusEditGamePublisherReview { get; set; }
        public string InstanceIdEditGamePublisherReview { get; set; }
        public int? InstanceSridEditGamePublisherReview { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
