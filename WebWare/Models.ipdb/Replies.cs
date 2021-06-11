using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class Replies
    {
        public int Id { get; set; }
        public int LetterId { get; set; }
        public string ReplyDate { get; set; }
        public string ReplyTime { get; set; }
        public string ReplyType { get; set; }
        public string CreatorId { get; set; }
        public string Title { get; set; }
        public string Receiver { get; set; }
        public string Context { get; set; }
        public string Priority { get; set; }
        public string PrivacyLevel { get; set; }
        public string TranscriptReceiver { get; set; }
        public string TranscriptHiddenReceiver { get; set; }
        public string Appendix { get; set; }
    }
}
