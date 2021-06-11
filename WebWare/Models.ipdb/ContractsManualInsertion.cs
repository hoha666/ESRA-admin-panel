using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class ContractsManualInsertion
    {
        public int Id { get; set; }
        public string TxtContractTitle { get; set; }
        public string DdlFirstContractorType { get; set; }
        public string DdlSecondContractorType { get; set; }
        public string TxtSecondContractorCompanyName { get; set; }
        public string TxtSecondContractorCompanyRegisterNumber { get; set; }
        public string TxtSecondContractorCompanyEconomyId { get; set; }
        public string TxtSecondContractorCompanyAgent { get; set; }
        public string TxtSecondContractorCompanyAgentPosition { get; set; }
        public string TxtSecondContractorCompanyAgentPhone { get; set; }
        public string TxtSecondContractorCompanyPhone { get; set; }
        public string TxtSecondContractorPersonName { get; set; }
        public string TxtSecondContractorPersonBirthCertificateNum { get; set; }
        public string TxtSecondContractorPersonNationalId { get; set; }
        public string TxtSecondContractorPersonPhone { get; set; }
        public string TxtSeconContractorPersonMobilePhone { get; set; }
        public string AxtFirstContractorAddress { get; set; }
        public string AxtSecondContractorAddress { get; set; }
        public string TxtGrossPrice { get; set; }
        public string AxtFirstContractorCommitments { get; set; }
        public string AxtSecondContractorCommitments { get; set; }
        public string DdlInsuranceRule38 { get; set; }
        public string DdlDirectTax { get; set; }
        public string DdlVat { get; set; }
        public string UplContractFile { get; set; }
        public string UplContractAttachmentsFile { get; set; }
        public string AxtContractExecutionPlce { get; set; }
        public string PdateContractStart { get; set; }
        public DateTime? PdateContractStartGregorian { get; set; }
        public string PdateContractEnd { get; set; }
        public DateTime? PdateContractEndGregorian { get; set; }
        public string AxtContractPeymentMethod { get; set; }
        public string CreatorContractsManualInsertion { get; set; }
        public string IpContractsManualInsertion { get; set; }
        public bool? RegistrationStatusContractsManualInsertion { get; set; }
        public string RegistrationDateContractsManualInsertion { get; set; }
        public string RegistrationTimeContractsManualInsertion { get; set; }
        public string AuditStatusContractsManualInsertion { get; set; }
        public string InstanceIdContractsManualInsertion { get; set; }
        public int? InstanceSridContractsManualInsertion { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
