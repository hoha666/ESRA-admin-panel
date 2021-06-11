using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class VgPrimaryInsertion
    {
        public int Id { get; set; }
        public string TxtName { get; set; }
        public string TxtSecondName { get; set; }
        public string TxtProducer { get; set; }
        public string DateFirstPublish { get; set; }
        public string CreatorVgPrimaryInsertion { get; set; }
        public string IpVgPrimaryInsertion { get; set; }
        public bool? RegistrationStatusVgPrimaryInsertion { get; set; }
        public string RegistrationDateVgPrimaryInsertion { get; set; }
        public string RegistrationTimeVgPrimaryInsertion { get; set; }
        public string AuditStatusVgPrimaryInsertion { get; set; }
        public string InstanceIdVgPrimaryInsertion { get; set; }
        public int? InstanceSridVgPrimaryInsertion { get; set; }
        public DateTime? DateFirstPublishGregorian { get; set; }
    }
}
