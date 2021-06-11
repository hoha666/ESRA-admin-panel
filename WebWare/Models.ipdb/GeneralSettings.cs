using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class GeneralSettings
    {
        public int Id { get; set; }
        public string HomeUrl { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Tags { get; set; }
        public string Description { get; set; }
        public DateTime InstallDate { get; set; }
        public bool Status { get; set; }
        public string PageNotFoundContent { get; set; }
        public string AccessDeniedContent { get; set; }
        public string ErrorPageContent { get; set; }
        public DateTime? RunDate { get; set; }
        public bool EnableRegistration { get; set; }
        public bool EnableUnlockRegistratin { get; set; }
        public bool EnablePasswordRecovery { get; set; }
        public int DefaultUserRoleId { get; set; }
        public string ActiveTemplateName { get; set; }
        public int ActiveTemplateId { get; set; }
        public int EmailSetting { get; set; }
        public string LoginUrl { get; set; }
        public byte AuthenticateTypes { get; set; }
        public string LdapConnection { get; set; }
        public string LdapUserName { get; set; }
        public string LdapPassword { get; set; }
        public bool StaySignedInIsActive { get; set; }
    }
}
