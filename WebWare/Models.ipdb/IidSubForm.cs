using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class IidSubForm
    {
        public int Id { get; set; }
        public string Ddleditable { get; set; }
        public string Ddlplatform { get; set; }
        public string Ddloriginal { get; set; }
        public string CreatorIidSubForm { get; set; }
        public string IpIidSubForm { get; set; }
        public bool? RegistrationStatusIidSubForm { get; set; }
        public string RegistrationDateIidSubForm { get; set; }
        public string RegistrationTimeIidSubForm { get; set; }
        public string AuditStatusIidSubForm { get; set; }
        public string InstanceIdIidSubForm { get; set; }
        public int? InstanceSridIidSubForm { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
        public string Vname { get; set; }
        public string Iid { get; set; }
    }
}
