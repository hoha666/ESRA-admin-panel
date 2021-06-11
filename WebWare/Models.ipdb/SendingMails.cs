using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class SendingMails
    {
        public SendingMails()
        {
            CheckingFormMessages = new HashSet<CheckingFormMessages>();
            ReceiverEmails = new HashSet<ReceiverEmails>();
        }

        public int Id { get; set; }
        public string Subject { get; set; }
        public string SenderEmail { get; set; }
        public string ReceiverMail { get; set; }
        public bool? IsSelectedEmail { get; set; }
        public string EmailText { get; set; }
        public string Description { get; set; }
        public bool? IsSendToCartable { get; set; }
        public bool? IsComplementaryOfForm { get; set; }
        public string UserId { get; set; }
        public string GroupId { get; set; }
        public bool? Editable { get; set; }
        public bool? IsSms { get; set; }
        public string SmsText { get; set; }
        public string ReceiverSms { get; set; }
        public string SenderSms { get; set; }
        public string UserIdSms { get; set; }
        public string GroupIdSms { get; set; }
        public bool? IsComplementaryOfFormSms { get; set; }
        public bool? IsSendMail { get; set; }
        public int? ReceiverEmailFromAnotherLeveleId { get; set; }
        public int? ReceiverSmsFromAnotherLeveleId { get; set; }
        public bool IsTsql { get; set; }
        public string Tsql { get; set; }

        public NodeDetails IdNavigation { get; set; }
        public ICollection<CheckingFormMessages> CheckingFormMessages { get; set; }
        public ICollection<ReceiverEmails> ReceiverEmails { get; set; }
    }
}
