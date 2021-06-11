using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class Pictogram2
    {
        public int Id { get; set; }
        public string Ddlpictogram2 { get; set; }
        public string TxtpictogramValue2 { get; set; }
        public string CreatorPictogram2 { get; set; }
        public string IpPictogram2 { get; set; }
        public bool? RegistrationStatusPictogram2 { get; set; }
        public string RegistrationDatePictogram2 { get; set; }
        public string RegistrationTimePictogram2 { get; set; }
        public string AuditStatusPictogram2 { get; set; }
        public string InstanceIdPictogram2 { get; set; }
        public int? InstanceSridPictogram2 { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }

        public WRadebandiSazmani ParentRecord { get; set; }
    }
}
