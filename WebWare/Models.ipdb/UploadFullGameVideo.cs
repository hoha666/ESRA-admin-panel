using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class UploadFullGameVideo
    {
        public int Id { get; set; }
        public string Upload { get; set; }
        public string TxaComment { get; set; }
        public string CreatorUploadFullGameVideo { get; set; }
        public string IpUploadFullGameVideo { get; set; }
        public bool? RegistrationStatusUploadFullGameVideo { get; set; }
        public string RegistrationDateUploadFullGameVideo { get; set; }
        public string RegistrationTimeUploadFullGameVideo { get; set; }
        public string AuditStatusUploadFullGameVideo { get; set; }
        public string InstanceIdUploadFullGameVideo { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
        public int? InstanceSridUploadFullGameVideo { get; set; }

        public GamerVideo ParentRecord { get; set; }
    }
}
