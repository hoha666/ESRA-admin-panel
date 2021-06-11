using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class CheckingFormMessages
    {
        public int Id { get; set; }
        public bool IsReadOnly { get; set; }
        public int? CheckingFormId { get; set; }
        public int? SendingMailId { get; set; }

        public CheckingForms CheckingForm { get; set; }
        public SendingMails SendingMail { get; set; }
    }
}
