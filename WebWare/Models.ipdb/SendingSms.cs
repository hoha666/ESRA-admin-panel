using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class SendingSms
    {
        public SendingSms()
        {
            ReceiverEmails = new HashSet<ReceiverEmails>();
        }

        public int Id { get; set; }
        public string UserId { get; set; }
        public string GroupId { get; set; }
        public string SenderSms { get; set; }
        public string ReceiverSms { get; set; }
        public bool? IsSelectedSms { get; set; }
        public string Smstext { get; set; }
        public string Description { get; set; }

        public NodeDetails IdNavigation { get; set; }
        public ICollection<ReceiverEmails> ReceiverEmails { get; set; }
    }
}
