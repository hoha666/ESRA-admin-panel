using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class OutsidePeoples
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string Organization { get; set; }
        public string Post { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
