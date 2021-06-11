using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class Sur030CheckContentRequest
    {
        public int Id { get; set; }
        public string DdlStatusReceivedForm { get; set; }
        public string AxtDescription { get; set; }
        public string CreatorSur030CheckContentRequest { get; set; }
        public string IpSur030CheckContentRequest { get; set; }
        public bool? RegistrationStatusSur030CheckContentRequest { get; set; }
        public string RegistrationDateSur030CheckContentRequest { get; set; }
        public string RegistrationTimeSur030CheckContentRequest { get; set; }
        public string AuditStatusSur030CheckContentRequest { get; set; }
        public string InstanceIdSur030CheckContentRequest { get; set; }
        public int? InstanceSridSur030CheckContentRequest { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
