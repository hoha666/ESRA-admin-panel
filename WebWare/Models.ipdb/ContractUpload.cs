using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class ContractUpload
    {
        public ContractUpload()
        {
            RelationPeopleContractUpload = new HashSet<RelationPeopleContractUpload>();
        }

        public int Id { get; set; }
        public string Contract { get; set; }
        public string CreatorContractUpload { get; set; }
        public string IpContractUpload { get; set; }
        public bool? RegistrationStatusContractUpload { get; set; }
        public string RegistrationDateContractUpload { get; set; }
        public string RegistrationTimeContractUpload { get; set; }
        public string AuditStatusContractUpload { get; set; }
        public string InstanceIdContractUpload { get; set; }
        public int? InstanceSridContractUpload { get; set; }
        public string ContractDate { get; set; }
        public string ContractId { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
        public DateTime? ContractDateGregorian { get; set; }

        public ICollection<RelationPeopleContractUpload> RelationPeopleContractUpload { get; set; }
    }
}
