using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class SourceMedia
    {
        public int Id { get; set; }
        public string DdlMediaType { get; set; }
        public string TxtMediaNumber { get; set; }
        public string CreatorSourceMedia { get; set; }
        public string IpSourceMedia { get; set; }
        public bool? RegistrationStatusSourceMedia { get; set; }
        public string RegistrationDateSourceMedia { get; set; }
        public string RegistrationTimeSourceMedia { get; set; }
        public string AuditStatusSourceMedia { get; set; }
        public string InstanceIdSourceMedia { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
        public int? InstanceSridSourceMedia { get; set; }

        public GameInformation ParentRecord { get; set; }
    }
}
