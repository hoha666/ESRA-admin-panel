using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class EsraMngtReport
    {
        public int Id { get; set; }
        public string DdlOpinion { get; set; }
        public string DdlAgeRating { get; set; }
        public string Ddl2ConditionalRating { get; set; }
        public string TxaComment { get; set; }
        public string Date { get; set; }
        public string CreatorEsraMngtReport { get; set; }
        public string IpEsraMngtReport { get; set; }
        public bool? RegistrationStatusEsraMngtReport { get; set; }
        public string RegistrationDateEsraMngtReport { get; set; }
        public string RegistrationTimeEsraMngtReport { get; set; }
        public string AuditStatusEsraMngtReport { get; set; }
        public string InstanceIdEsraMngtReport { get; set; }
        public int? InstanceSridEsraMngtReport { get; set; }
        public DateTime? DateGregorian { get; set; }
    }
}
