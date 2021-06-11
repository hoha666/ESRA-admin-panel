using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class DefectiveSource
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public string GameCode { get; set; }
        public string Publisher { get; set; }
        public DateTime DefectiveSubmitDate { get; set; }
        public string Gamer { get; set; }
    }
}
