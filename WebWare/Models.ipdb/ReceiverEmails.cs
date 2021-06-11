using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class ReceiverEmails
    {
        public int Id { get; set; }
        public string TableName { get; set; }
        public string TableField { get; set; }
        public string TableRecord { get; set; }
        public int SendingMailId { get; set; }
        public bool IsMail { get; set; }
        public int? SendingSmsId { get; set; }

        public SendingMails SendingMail { get; set; }
        public SendingSms SendingSms { get; set; }
    }
}
