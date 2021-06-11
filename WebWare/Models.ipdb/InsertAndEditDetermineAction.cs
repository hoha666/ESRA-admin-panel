using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class InsertAndEditDetermineAction
    {
        public int Id { get; set; }
        public string DdlDetermineTypeOfAction { get; set; }
        public string CreatorInsertAndEditDetermineAction { get; set; }
        public string IpInsertAndEditDetermineAction { get; set; }
        public bool? RegistrationStatusInsertAndEditDetermineAction { get; set; }
        public string RegistrationDateInsertAndEditDetermineAction { get; set; }
        public string RegistrationTimeInsertAndEditDetermineAction { get; set; }
        public string AuditStatusInsertAndEditDetermineAction { get; set; }
        public string InstanceIdInsertAndEditDetermineAction { get; set; }
        public int? InstanceSridInsertAndEditDetermineAction { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
