using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class CalendarEventGroupShares
    {
        public int CalendarEventGroupShareId { get; set; }
        public int CalendarEventId { get; set; }
        public int GroupId { get; set; }

        public CalenderEvents CalendarEvent { get; set; }
    }
}
