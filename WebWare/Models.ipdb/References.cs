using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class References
    {
        public int Id { get; set; }
        public string LetterId { get; set; }
        public string SenderId { get; set; }
        public string ReceiverId { get; set; }
        public string ReferenceType { get; set; }
        public string ReferenceDate { get; set; }
        public string ReferenceTime { get; set; }
    }
}
