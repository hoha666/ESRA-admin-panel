using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class Notifications
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public string Reciver { get; set; }
        public DateTime SentDate { get; set; }
        public bool Status { get; set; }
    }
}
