using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class ContractSealRequest
    {
        public int Id { get; set; }
        public string TxtConTitle { get; set; }
        public string DdlKind { get; set; }
        public string TxtCompanyName { get; set; }
        public string TxtFullNameLegalPerson { get; set; }
        public string TxtLegalPersonPosition { get; set; }
        public string CreatorContractSealRequest { get; set; }
        public string IpContractSealRequest { get; set; }
        public bool? RegistrationStatusContractSealRequest { get; set; }
        public string RegistrationDateContractSealRequest { get; set; }
        public string RegistrationTimeContractSealRequest { get; set; }
        public string AuditStatusContractSealRequest { get; set; }
        public string InstanceIdContractSealRequest { get; set; }
        public int? InstanceSridContractSealRequest { get; set; }
        public string TxtCompanyregisterNumber { get; set; }
        public string TxaCompanyAddress { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
        public string TxtOrganizationTel { get; set; }
        public string TxtAgentTel { get; set; }
        public string TxtLfname { get; set; }
        public string TxaAddress { get; set; }
        public string TxtTel { get; set; }
        public string TxtPhone { get; set; }
        public string TxaFcommitments { get; set; }
        public string TxaLcommitments { get; set; }
        public string TxtContractPlace { get; set; }
        public string TxaContractPrice { get; set; }
        public string DdlcontractAssurance { get; set; }
        public string NationalCode { get; set; }
        public string Bcnumber { get; set; }
        public string Flezamimeh { get; set; }
        public string TxtProgramQuestionA { get; set; }
        public string TxtProgramQuestionB { get; set; }
        public string DateStart { get; set; }
        public DateTime? DateStartGregorian { get; set; }
        public string DateEnd { get; set; }
        public DateTime? DateEndGregorian { get; set; }
    }
}
