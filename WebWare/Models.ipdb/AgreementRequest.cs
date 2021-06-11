using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class AgreementRequest
    {
        public AgreementRequest()
        {
            RelationPeopleAgreementRequest = new HashSet<RelationPeopleAgreementRequest>();
        }

        public int Id { get; set; }
        public string TxtTitle { get; set; }
        public string DdlKing { get; set; }
        public string TxtOrganizationName { get; set; }
        public string TxtAgentName { get; set; }
        public string TxtAgentPost { get; set; }
        public string TxtOrganizationId { get; set; }
        public string TxaOrganizationAddress { get; set; }
        public string TxtOrganizationTel { get; set; }
        public string TxtAgentTel { get; set; }
        public string TxtLfname { get; set; }
        public string TxaAddress { get; set; }
        public string TxtPhone { get; set; }
        public string TxtTel { get; set; }
        public string TxaFcommitments { get; set; }
        public string TxaLcommitments { get; set; }
        public string TxaContractPlace { get; set; }
        public string TxaContractTime { get; set; }
        public string CreatorAgreementRequest { get; set; }
        public string IpAgreementRequest { get; set; }
        public bool? RegistrationStatusAgreementRequest { get; set; }
        public string RegistrationDateAgreementRequest { get; set; }
        public string RegistrationTimeAgreementRequest { get; set; }
        public string AuditStatusAgreementRequest { get; set; }
        public string InstanceIdAgreementRequest { get; set; }
        public int? InstanceSridAgreementRequest { get; set; }
        public string Ddl2Unit { get; set; }
        public string Ddl2MainActivity { get; set; }
        public string Ddl2SubActivity { get; set; }
        public string NationalCode { get; set; }
        public string Bcnumber { get; set; }

        public ICollection<RelationPeopleAgreementRequest> RelationPeopleAgreementRequest { get; set; }
    }
}
