using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class SubmitSource
    {
        public SubmitSource()
        {
            RelationTblOrganizationBonyadSubmitSource = new HashSet<RelationTblOrganizationBonyadSubmitSource>();
        }

        public int Id { get; set; }
        public string Result { get; set; }
        public string CreatorSubmitSource { get; set; }
        public string IpSubmitSource { get; set; }
        public bool? RegistrationStatusSubmitSource { get; set; }
        public string RegistrationDateSubmitSource { get; set; }
        public string RegistrationTimeSubmitSource { get; set; }
        public string AuditStatusSubmitSource { get; set; }
        public string InstanceIdSubmitSource { get; set; }
        public int? InstanceSridSubmitSource { get; set; }
        public string DdlCompanyRepeat { get; set; }
        public string TxtCn { get; set; }
        public string TxtVid { get; set; }

        public ICollection<RelationTblOrganizationBonyadSubmitSource> RelationTblOrganizationBonyadSubmitSource { get; set; }
    }
}
