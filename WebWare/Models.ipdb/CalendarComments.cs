using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class CalendarComments
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public string UsersId { get; set; }
        public string UsersComments { get; set; }
        public string GroupId { get; set; }
        public string GroupComments { get; set; }
    }
}
