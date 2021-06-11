using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class IndieProjectTitles
    {
        public int Id { get; set; }
        public string TxtProjectTitle { get; set; }
        public string CreatorIndieProjectTitles { get; set; }
        public string IpIndieProjectTitles { get; set; }
        public bool? RegistrationStatusIndieProjectTitles { get; set; }
        public string RegistrationDateIndieProjectTitles { get; set; }
        public string RegistrationTimeIndieProjectTitles { get; set; }
        public string AuditStatusIndieProjectTitles { get; set; }
        public string InstanceIdIndieProjectTitles { get; set; }
        public int? InstanceSridIndieProjectTitles { get; set; }
        public string Txtkarfarma { get; set; }
        public string Txtmasooliat { get; set; }
        public string Datestart { get; set; }
        public string Dateend { get; set; }
        public string Combohoze { get; set; }
        public string Txtsharhehoze { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }

        public IndieDeveloperRegisterForm ParentRecord { get; set; }
    }
}
