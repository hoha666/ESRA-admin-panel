using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class CartableLetters
    {
        public int Id { get; set; }
        public string CartableId { get; set; }
        public string LetterId { get; set; }
        public string Status { get; set; }
        public string Star { get; set; }
        public string Read { get; set; }
        public string FolderId { get; set; }
        public string Access { get; set; }
        public string PreviousAccess { get; set; }
        public string LetterOperation { get; set; }
        public string PreviousLetterOperation { get; set; }
        public string CartableLetterDate { get; set; }
        public string CartableLetterTime { get; set; }
        public string SystemId { get; set; }
        public string ReplyId { get; set; }
        public int Type { get; set; }
        public int? LetterId1 { get; set; }
        public int? UserMessageId { get; set; }
        public int? WfwInstanceStateReceiverId { get; set; }
        public int? CalenderEventId { get; set; }
        public int? ProceedingsId { get; set; }
        public bool IsHide { get; set; }

        public CalenderEvents CalenderEvent { get; set; }
        public Letters LetterId1Navigation { get; set; }
        public CalenderEvents Proceedings { get; set; }
        public UserMessages UserMessage { get; set; }
        public WfwInstanceStateReceivers WfwInstanceStateReceiver { get; set; }
    }
}
