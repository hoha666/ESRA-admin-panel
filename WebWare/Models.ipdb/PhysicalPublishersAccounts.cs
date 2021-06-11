using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class PhysicalPublishersAccounts
    {
        public int Id { get; set; }
        public int? NumPrimaryPublisherHologram { get; set; }
        public int? NumPublisherRating { get; set; }
        public int? NumGreenHologram { get; set; }
        public string UplDocumentation { get; set; }
        public string CreatorPhysicalPublishersAccounts { get; set; }
        public string IpPhysicalPublishersAccounts { get; set; }
        public bool? RegistrationStatusPhysicalPublishersAccounts { get; set; }
        public string RegistrationDatePhysicalPublishersAccounts { get; set; }
        public string RegistrationTimePhysicalPublishersAccounts { get; set; }
        public string AuditStatusPhysicalPublishersAccounts { get; set; }
        public string InstanceIdPhysicalPublishersAccounts { get; set; }
        public int? InstanceSridPhysicalPublishersAccounts { get; set; }
        public string UplPrimaryHologramDocumentation { get; set; }
        public string UplPrimaryScoreDocumentation { get; set; }
    }
}
