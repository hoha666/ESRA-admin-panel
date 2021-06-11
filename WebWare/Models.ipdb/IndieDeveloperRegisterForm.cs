using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class IndieDeveloperRegisterForm
    {
        public IndieDeveloperRegisterForm()
        {
            IndieProjectTitles = new HashSet<IndieProjectTitles>();
        }

        public int Id { get; set; }
        public string TxtName { get; set; }
        public string TxtAddress { get; set; }
        public string TxtTelephone { get; set; }
        public string TxtEmail { get; set; }
        public string FileShenasnameh { get; set; }
        public string FileKarteMelli { get; set; }
        public string FileResume { get; set; }
        public string FileMadrak { get; set; }
        public string CreatorIndieDeveloperRegisterForm { get; set; }
        public string IpIndieDeveloperRegisterForm { get; set; }
        public bool? RegistrationStatusIndieDeveloperRegisterForm { get; set; }
        public string RegistrationDateIndieDeveloperRegisterForm { get; set; }
        public string RegistrationTimeIndieDeveloperRegisterForm { get; set; }
        public string AuditStatusIndieDeveloperRegisterForm { get; set; }
        public string InstanceIdIndieDeveloperRegisterForm { get; set; }
        public int? InstanceSridIndieDeveloperRegisterForm { get; set; }
        public string Filepic2 { get; set; }

        public ICollection<IndieProjectTitles> IndieProjectTitles { get; set; }
    }
}
