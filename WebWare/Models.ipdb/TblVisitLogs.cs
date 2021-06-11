using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblVisitLogs
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public string UserIp { get; set; }
        public string UserAgent { get; set; }
        public string Url { get; set; }
    }
}
