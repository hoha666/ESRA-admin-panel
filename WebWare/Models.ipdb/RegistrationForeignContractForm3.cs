using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RegistrationForeignContractForm3
    {
        public int Id { get; set; }
        public string TxtContractSubject { get; set; }
        public string TxtPartyContract { get; set; }
        public int? NumContractNumber { get; set; }
        public string PdateDateOfContract { get; set; }
        public DateTime? PdateDateOfContractGregorian { get; set; }
        public int? NumTotalAmountContract { get; set; }
        public int? NumNumberInstallments { get; set; }
        public int? NumAmountInstallment { get; set; }
        public int? NumTermContract { get; set; }
        public string UplContractImage { get; set; }
        public string PdateDeliveryDateRegistration { get; set; }
        public DateTime? PdateDeliveryDateRegistrationGregorian { get; set; }
        public string UplAttachedPicture { get; set; }
        public string AxtDescription { get; set; }
        public string CreatorRegistrationForeignContractForm3 { get; set; }
        public string IpRegistrationForeignContractForm3 { get; set; }
        public bool? RegistrationStatusRegistrationForeignContractForm3 { get; set; }
        public string RegistrationDateRegistrationForeignContractForm3 { get; set; }
        public string RegistrationTimeRegistrationForeignContractForm3 { get; set; }
        public string AuditStatusRegistrationForeignContractForm3 { get; set; }
        public string InstanceIdRegistrationForeignContractForm3 { get; set; }
        public int? InstanceSridRegistrationForeignContractForm3 { get; set; }
        public string TxtContractObserver { get; set; }
    }
}
