using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class WorkExperience
    {
        public int Id { get; set; }
        public string TxtActivityType { get; set; }
        public string TxtPost { get; set; }
        public string DdlServiceType { get; set; }
        public string TxtWorkPlace { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string TxaDueToLeave { get; set; }
        public string CreatorWorkExperience { get; set; }
        public string IpWorkExperience { get; set; }
        public bool? RegistrationStatusWorkExperience { get; set; }
        public string RegistrationDateWorkExperience { get; set; }
        public string RegistrationTimeWorkExperience { get; set; }
        public string AuditStatusWorkExperience { get; set; }
        public string InstanceIdWorkExperience { get; set; }
        public int? InstanceSridWorkExperience { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }

        public InstitutionExecutivesProfile ParentRecord { get; set; }
    }
}
