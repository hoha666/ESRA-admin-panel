using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class BankHologramReserved
    {
        public int Id { get; set; }
        public long? NumHologramRecorded { get; set; }
        public long? NumHologramAdded { get; set; }
        public long? NumHologramAttached { get; set; }
        public long? NumRemainingHolograms { get; set; }
        public string AxtDescription { get; set; }
        public string UplDocumentation { get; set; }
        public string CreatorBankHologramReserved { get; set; }
        public string IpBankHologramReserved { get; set; }
        public bool? RegistrationStatusBankHologramReserved { get; set; }
        public string RegistrationDateBankHologramReserved { get; set; }
        public string RegistrationTimeBankHologramReserved { get; set; }
        public string AuditStatusBankHologramReserved { get; set; }
        public string InstanceIdBankHologramReserved { get; set; }
        public int? InstanceSridBankHologramReserved { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
