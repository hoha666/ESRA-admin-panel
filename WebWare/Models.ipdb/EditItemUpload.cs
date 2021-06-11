using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class EditItemUpload
    {
        public EditItemUpload()
        {
            SubEditItemUpload = new HashSet<SubEditItemUpload>();
        }

        public int Id { get; set; }
        public string TxaDescription { get; set; }
        public string CreatorEditItemUpload { get; set; }
        public string IpEditItemUpload { get; set; }
        public bool? RegistrationStatusEditItemUpload { get; set; }
        public string RegistrationDateEditItemUpload { get; set; }
        public string RegistrationTimeEditItemUpload { get; set; }
        public string AuditStatusEditItemUpload { get; set; }
        public string InstanceIdEditItemUpload { get; set; }
        public int? InstanceSridEditItemUpload { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }

        public ICollection<SubEditItemUpload> SubEditItemUpload { get; set; }
    }
}
