using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class GreenHologramUploadDocumentation
    {
        public int Id { get; set; }
        public string UplUploadImage { get; set; }
        public string AxtDescription { get; set; }
        public string CreatorGreenHologramUploadDocumentation { get; set; }
        public string IpGreenHologramUploadDocumentation { get; set; }
        public bool? RegistrationStatusGreenHologramUploadDocumentation { get; set; }
        public string RegistrationDateGreenHologramUploadDocumentation { get; set; }
        public string RegistrationTimeGreenHologramUploadDocumentation { get; set; }
        public string AuditStatusGreenHologramUploadDocumentation { get; set; }
        public string InstanceIdGreenHologramUploadDocumentation { get; set; }
        public int? InstanceSridGreenHologramUploadDocumentation { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
