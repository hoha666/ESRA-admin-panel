using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class InstitutionExecutives
    {
        public int Id { get; set; }
        public string TxtFname { get; set; }
        public string TxtLname { get; set; }
        public string TxtIdNumber { get; set; }
        public string TxtNationalCode { get; set; }
        public string DdlResponsibilityType { get; set; }
        public string CreatorInstitutionExecutives { get; set; }
        public string IpInstitutionExecutives { get; set; }
        public bool? RegistrationStatusInstitutionExecutives { get; set; }
        public string RegistrationDateInstitutionExecutives { get; set; }
        public string RegistrationTimeInstitutionExecutives { get; set; }
        public string AuditStatusInstitutionExecutives { get; set; }
        public string InstanceIdInstitutionExecutives { get; set; }
        public int? InstanceSridInstitutionExecutives { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }

        public SinglePurposeInstitutionProfile ParentRecord { get; set; }
    }
}
