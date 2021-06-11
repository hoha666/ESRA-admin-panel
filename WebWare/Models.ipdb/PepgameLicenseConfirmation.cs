using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class PepgameLicenseConfirmation
    {
        public int Id { get; set; }
        public string Rejected { get; set; }
        public string RejectedComment { get; set; }
        public string Accepted { get; set; }
        public string AcceptedComment { get; set; }
        public string CreatorPepgameLicenseConfirmation { get; set; }
        public string IpPepgameLicenseConfirmation { get; set; }
        public bool? RegistrationStatusPepgameLicenseConfirmation { get; set; }
        public string RegistrationDatePepgameLicenseConfirmation { get; set; }
        public string RegistrationTimePepgameLicenseConfirmation { get; set; }
        public string AuditStatusPepgameLicenseConfirmation { get; set; }
        public string InstanceIdPepgameLicenseConfirmation { get; set; }
        public int? InstanceSridPepgameLicenseConfirmation { get; set; }
    }
}
