using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class SubEditItemUpload
    {
        public int Id { get; set; }
        public string CreatorSubEditItemUpload { get; set; }
        public string IpSubEditItemUpload { get; set; }
        public bool? RegistrationStatusSubEditItemUpload { get; set; }
        public string RegistrationDateSubEditItemUpload { get; set; }
        public string RegistrationTimeSubEditItemUpload { get; set; }
        public string AuditStatusSubEditItemUpload { get; set; }
        public string InstanceIdSubEditItemUpload { get; set; }
        public int? InstanceSridSubEditItemUpload { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
        public string Uplfilms { get; set; }

        public EditItemUpload ParentRecord { get; set; }
    }
}
