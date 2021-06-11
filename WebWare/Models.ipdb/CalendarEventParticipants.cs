using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class CalendarEventParticipants
    {
        public int CalendarEventParticipantId { get; set; }
        public int CalendarEventId { get; set; }
        public string UserName { get; set; }

        public CalenderEvents CalendarEvent { get; set; }
    }
}
