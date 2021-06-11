using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class InsertOperatorSelect
    {
        public int Id { get; set; }
        public string DdlOperator { get; set; }
        public string CreatorInsertOperatorSelect { get; set; }
        public string IpInsertOperatorSelect { get; set; }
        public bool? RegistrationStatusInsertOperatorSelect { get; set; }
        public string RegistrationDateInsertOperatorSelect { get; set; }
        public string RegistrationTimeInsertOperatorSelect { get; set; }
        public string AuditStatusInsertOperatorSelect { get; set; }
        public string InstanceIdInsertOperatorSelect { get; set; }
        public int? InstanceSridInsertOperatorSelect { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
