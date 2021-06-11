using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class DataModelInformation
    {
        public int Id { get; set; }
        public string CkDminfo { get; set; }
        public string UplDocs { get; set; }
        public string CreatorDataModelInformation { get; set; }
        public string IpDataModelInformation { get; set; }
        public bool? RegistrationStatusDataModelInformation { get; set; }
        public string RegistrationDateDataModelInformation { get; set; }
        public string RegistrationTimeDataModelInformation { get; set; }
        public string AuditStatusDataModelInformation { get; set; }
        public string InstanceIdDataModelInformation { get; set; }
        public int? InstanceSridDataModelInformation { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
