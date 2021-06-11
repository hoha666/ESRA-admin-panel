using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class Conditions
    {
        public int Id { get; set; }
        public int LawId { get; set; }
        public int Field1 { get; set; }
        public string State { get; set; }
        public string Target { get; set; }
        public string Value { get; set; }
        public int Field2 { get; set; }

        public Laws Law { get; set; }
    }
}
