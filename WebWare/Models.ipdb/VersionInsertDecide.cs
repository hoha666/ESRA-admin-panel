using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class VersionInsertDecide
    {
        public int Id { get; set; }
        public string CreatorVersionInsertDecide { get; set; }
        public string IpVersionInsertDecide { get; set; }
        public bool? RegistrationStatusVersionInsertDecide { get; set; }
        public string RegistrationDateVersionInsertDecide { get; set; }
        public string RegistrationTimeVersionInsertDecide { get; set; }
        public string AuditStatusVersionInsertDecide { get; set; }
        public string InstanceIdVersionInsertDecide { get; set; }
        public int? InstanceSridVersionInsertDecide { get; set; }
        public string DdlOrgDecide { get; set; }
        public string TxtCompanyName { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
