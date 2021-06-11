using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class EsraMngt2
    {
        public int Id { get; set; }
        public string DdlMode { get; set; }
        public string DdlRadeh { get; set; }
        public string TxaTozih { get; set; }
        public string PdateRadeh { get; set; }
        public DateTime? PdateRadehGregorian { get; set; }
        public string CreatorEsraMngt2 { get; set; }
        public string IpEsraMngt2 { get; set; }
        public bool? RegistrationStatusEsraMngt2 { get; set; }
        public string RegistrationDateEsraMngt2 { get; set; }
        public string RegistrationTimeEsraMngt2 { get; set; }
        public string AuditStatusEsraMngt2 { get; set; }
        public string InstanceIdEsraMngt2 { get; set; }
        public int? InstanceSridEsraMngt2 { get; set; }
    }
}
