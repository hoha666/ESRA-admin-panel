using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class SmsMessages
    {
        public int Id { get; set; }
        public string ReceiverMobile { get; set; }
        public string Text { get; set; }
        public bool Sent { get; set; }
        public DateTime SentDateTime { get; set; }
        public DateTime CreateDateTime { get; set; }
        public int TryCount { get; set; }
    }
}
