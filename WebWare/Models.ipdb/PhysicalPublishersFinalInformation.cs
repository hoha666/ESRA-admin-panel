using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class PhysicalPublishersFinalInformation
    {
        public int Id { get; set; }
        public string DdlApplicantType { get; set; }
        public string TxtNameCompany { get; set; }
        public int? NumRegistrationNumber { get; set; }
        public int? NumEconomicCode { get; set; }
        public string Pdate { get; set; }
        public DateTime? PdateGregorian { get; set; }
        public string DdlKind { get; set; }
        public int? NumPostalCode { get; set; }
        public string TxtNameCeo { get; set; }
        public string TxtSurnameCeo { get; set; }
        public int? NumNationalCodeCeo { get; set; }
        public string UplDocumentation { get; set; }
        public string CreatorPhysicalPublishersFinalInformation { get; set; }
        public string IpPhysicalPublishersFinalInformation { get; set; }
        public bool? RegistrationStatusPhysicalPublishersFinalInformation { get; set; }
        public string RegistrationDatePhysicalPublishersFinalInformation { get; set; }
        public string RegistrationTimePhysicalPublishersFinalInformation { get; set; }
        public string AuditStatusPhysicalPublishersFinalInformation { get; set; }
        public string InstanceIdPhysicalPublishersFinalInformation { get; set; }
        public int? InstanceSridPhysicalPublishersFinalInformation { get; set; }
        public string AxtDescription { get; set; }
    }
}
