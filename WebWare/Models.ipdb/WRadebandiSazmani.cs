using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class WRadebandiSazmani
    {
        public WRadebandiSazmani()
        {
            Pictogram2 = new HashSet<Pictogram2>();
        }

        public int Id { get; set; }
        public string CreatorWRadebandiSazmani { get; set; }
        public string IpWRadebandiSazmani { get; set; }
        public bool? RegistrationStatusWRadebandiSazmani { get; set; }
        public string RegistrationDateWRadebandiSazmani { get; set; }
        public string RegistrationTimeWRadebandiSazmani { get; set; }
        public string AuditStatusWRadebandiSazmani { get; set; }
        public string InstanceIdWRadebandiSazmani { get; set; }
        public int? InstanceSridWRadebandiSazmani { get; set; }
        public string TxaKholaseRadeBandi { get; set; }
        public string DdlRate { get; set; }
        public string UploadIcon { get; set; }

        public ICollection<Pictogram2> Pictogram2 { get; set; }
    }
}
