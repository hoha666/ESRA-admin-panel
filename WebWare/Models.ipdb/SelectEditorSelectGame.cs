using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class SelectEditorSelectGame
    {
        public int Id { get; set; }
        public string CreatorSelectEditorSelectGame { get; set; }
        public string IpSelectEditorSelectGame { get; set; }
        public bool? RegistrationStatusSelectEditorSelectGame { get; set; }
        public string RegistrationDateSelectEditorSelectGame { get; set; }
        public string RegistrationTimeSelectEditorSelectGame { get; set; }
        public string AuditStatusSelectEditorSelectGame { get; set; }
        public string InstanceIdSelectEditorSelectGame { get; set; }
        public int? InstanceSridSelectEditorSelectGame { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
