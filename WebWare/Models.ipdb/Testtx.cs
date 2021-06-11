using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class Testtx
    {
        public int Id { get; set; }
        public string CreatorTesttx { get; set; }
        public string IpTesttx { get; set; }
        public bool? RegistrationStatusTesttx { get; set; }
        public string RegistrationDateTesttx { get; set; }
        public string RegistrationTimeTesttx { get; set; }
        public string AuditStatusTesttx { get; set; }
        public string InstanceIdTesttx { get; set; }
        public int? InstanceSridTesttx { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
        public string Cbla { get; set; }
        public string Txtb { get; set; }
    }
}
