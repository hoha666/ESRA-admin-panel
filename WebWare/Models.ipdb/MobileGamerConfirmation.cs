using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class MobileGamerConfirmation
    {
        public int Id { get; set; }
        public string GameDescription { get; set; }
        public string Result { get; set; }
        public string AgeRating { get; set; }
        public string Comment { get; set; }
        public string FileUpload { get; set; }
        public string IconUpload { get; set; }
        public string CreatorMobileGamerConfirmation { get; set; }
        public string IpMobileGamerConfirmation { get; set; }
        public bool? RegistrationStatusMobileGamerConfirmation { get; set; }
        public string RegistrationDateMobileGamerConfirmation { get; set; }
        public string RegistrationTimeMobileGamerConfirmation { get; set; }
        public string AuditStatusMobileGamerConfirmation { get; set; }
        public string InstanceIdMobileGamerConfirmation { get; set; }
        public int? InstanceSridMobileGamerConfirmation { get; set; }
    }
}
