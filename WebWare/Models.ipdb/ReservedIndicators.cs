using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class ReservedIndicators
    {
        public int Id { get; set; }
        public string IndicatorCode { get; set; }
        public string Description { get; set; }
        public string ReserverId { get; set; }
        public string ReserveDate { get; set; }
        public string AccessLevel { get; set; }
    }
}
