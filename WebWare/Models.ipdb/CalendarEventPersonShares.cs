using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class CalendarEventPersonShares
    {
        public int CalendarEventPersonShareId { get; set; }
        public int CalendarEventId { get; set; }
        public string UserName { get; set; }

        public CalenderEvents CalendarEvent { get; set; }
    }
}
