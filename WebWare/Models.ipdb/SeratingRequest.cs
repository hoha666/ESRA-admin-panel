using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class SeratingRequest
    {
        public SeratingRequest()
        {
            SourceEratingRequestSubform = new HashSet<SourceEratingRequestSubform>();
        }

        public int Id { get; set; }
        public string CreatorSeratingRequest { get; set; }
        public string IpSeratingRequest { get; set; }
        public bool? RegistrationStatusSeratingRequest { get; set; }
        public string RegistrationDateSeratingRequest { get; set; }
        public string RegistrationTimeSeratingRequest { get; set; }
        public string AuditStatusSeratingRequest { get; set; }
        public string InstanceIdSeratingRequest { get; set; }
        public int? InstanceSridSeratingRequest { get; set; }

        public ICollection<SourceEratingRequestSubform> SourceEratingRequestSubform { get; set; }
    }
}
