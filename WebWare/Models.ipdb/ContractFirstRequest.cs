using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class ContractFirstRequest
    {
        public ContractFirstRequest()
        {
            RelationPeopleContractFirstRequest = new HashSet<RelationPeopleContractFirstRequest>();
        }

        public int Id { get; set; }
        public string TxtContractSuject { get; set; }
        public string CreatorContractFirstRequest { get; set; }
        public string IpContractFirstRequest { get; set; }
        public bool? RegistrationStatusContractFirstRequest { get; set; }
        public string RegistrationDateContractFirstRequest { get; set; }
        public string RegistrationTimeContractFirstRequest { get; set; }
        public string AuditStatusContractFirstRequest { get; set; }
        public string InstanceIdContractFirstRequest { get; set; }
        public int? InstanceSridContractFirstRequest { get; set; }
        public string DdlKind { get; set; }
        public string TxtOrganizationName { get; set; }
        public string TxtAgentName { get; set; }
        public string TxtAgentPost { get; set; }
        public string TxtOrganizationId { get; set; }
        public string TxaOrganizationAddress { get; set; }
        public string TxtOrganizationTel { get; set; }
        public string TxtAgentTel { get; set; }
        public string TxtLfname { get; set; }
        public string TxaAddress { get; set; }
        public string TxtTel { get; set; }
        public string TxaFcommitments { get; set; }
        public string TxaLcommitments { get; set; }
        public string TxtContractPlace { get; set; }
        public string TxaContractTime { get; set; }
        public string TxaContractPrice { get; set; }
        public string DdlcontractAssurance { get; set; }
        public string TxtPhone { get; set; }
        public string DdlUnits { get; set; }
        public string DdlMainActivities { get; set; }
        public string DdlSubActivities { get; set; }
        public string TxtSupervisor { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
        public string NationalCode { get; set; }
        public string Bcnumber { get; set; }
        public string TxtSubActivities { get; set; }
        public string Flezamimeh { get; set; }

        public ICollection<RelationPeopleContractFirstRequest> RelationPeopleContractFirstRequest { get; set; }
    }
}
