using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RegisterPyramidTeamsPreRegistration
    {
        public int Id { get; set; }
        public string TxtName { get; set; }
        public string TxtLastName { get; set; }
        public string NumNationalCode { get; set; }
        public string TxtPassword { get; set; }
        public string TxtRpassword { get; set; }
        public string MailEAddress { get; set; }
        public string CreatorRegisterPyramidTeamsPreRegistration { get; set; }
        public string IpRegisterPyramidTeamsPreRegistration { get; set; }
        public bool? RegistrationStatusRegisterPyramidTeamsPreRegistration { get; set; }
        public string RegistrationDateRegisterPyramidTeamsPreRegistration { get; set; }
        public string RegistrationTimeRegisterPyramidTeamsPreRegistration { get; set; }
        public string AuditStatusRegisterPyramidTeamsPreRegistration { get; set; }
        public string InstanceIdRegisterPyramidTeamsPreRegistration { get; set; }
        public int? InstanceSridRegisterPyramidTeamsPreRegistration { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
