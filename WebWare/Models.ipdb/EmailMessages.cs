using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class EmailMessages
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string To { get; set; }
        public string Body { get; set; }
        public bool Sent { get; set; }
        public DateTime SentDateTime { get; set; }
        public DateTime CreateDateTime { get; set; }
        public int TryCount { get; set; }
    }
}
