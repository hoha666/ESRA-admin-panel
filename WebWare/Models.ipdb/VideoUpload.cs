using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class VideoUpload
    {
        public int Id { get; set; }
        public string TxtTitle { get; set; }
        public string VideoUpload1 { get; set; }
        public string TxaComment { get; set; }
        public string CreatorVideoUpload { get; set; }
        public string IpVideoUpload { get; set; }
        public bool? RegistrationStatusVideoUpload { get; set; }
        public string RegistrationDateVideoUpload { get; set; }
        public string RegistrationTimeVideoUpload { get; set; }
        public string AuditStatusVideoUpload { get; set; }
        public string InstanceIdVideoUpload { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
        public int? InstanceSridVideoUpload { get; set; }

        public GamerVideo ParentRecord { get; set; }
    }
}
