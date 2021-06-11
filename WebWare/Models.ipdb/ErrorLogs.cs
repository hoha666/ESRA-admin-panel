using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class ErrorLogs
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public string Source { get; set; }
        public string Path { get; set; }
        public DateTime ErrorDate { get; set; }
        public string UserName { get; set; }
        public int LogType { get; set; }
    }
}
