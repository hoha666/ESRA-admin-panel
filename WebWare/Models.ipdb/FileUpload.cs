using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class FileUpload
    {
        public int Id { get; set; }
        public string FileUpload1 { get; set; }
        public string CreatorFileUpload { get; set; }
        public string IpFileUpload { get; set; }
        public bool? RegistrationStatusFileUpload { get; set; }
        public string RegistrationDateFileUpload { get; set; }
        public string RegistrationTimeFileUpload { get; set; }
        public string AuditStatusFileUpload { get; set; }
        public string InstanceIdFileUpload { get; set; }
        public int? InstanceSridFileUpload { get; set; }
    }
}
