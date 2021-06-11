using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class DisseminationListItemsCourse
    {
        public int Id { get; set; }
        public string CreatorDisseminationListItemsCourse { get; set; }
        public string IpDisseminationListItemsCourse { get; set; }
        public bool? RegistrationStatusDisseminationListItemsCourse { get; set; }
        public string RegistrationDateDisseminationListItemsCourse { get; set; }
        public string RegistrationTimeDisseminationListItemsCourse { get; set; }
        public string AuditStatusDisseminationListItemsCourse { get; set; }
        public string InstanceIdDisseminationListItemsCourse { get; set; }
        public int? InstanceSridDisseminationListItemsCourse { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
