using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class SinglePurposeInstitutionProfile
    {
        public SinglePurposeInstitutionProfile()
        {
            InstitutionExecutives = new HashSet<InstitutionExecutives>();
        }

        public int Id { get; set; }
        public string TxtSuggestedName { get; set; }
        public string TxaSummaryObjectives { get; set; }
        public string ChkSubjectOfActivity { get; set; }
        public string TxaAddress { get; set; }
        public string ChkObligation { get; set; }
        public string CreatorSinglePurposeInstitutionProfile { get; set; }
        public string IpSinglePurposeInstitutionProfile { get; set; }
        public bool? RegistrationStatusSinglePurposeInstitutionProfile { get; set; }
        public string RegistrationDateSinglePurposeInstitutionProfile { get; set; }
        public string RegistrationTimeSinglePurposeInstitutionProfile { get; set; }
        public string AuditStatusSinglePurposeInstitutionProfile { get; set; }
        public string InstanceIdSinglePurposeInstitutionProfile { get; set; }
        public int? InstanceSridSinglePurposeInstitutionProfile { get; set; }
        public string TxtSuggestedName2 { get; set; }
        public string TxtSuggestedNames3 { get; set; }

        public ICollection<InstitutionExecutives> InstitutionExecutives { get; set; }
    }
}
