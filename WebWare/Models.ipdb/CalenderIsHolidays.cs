using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class CalenderIsHolidays
    {
        public int Id { get; set; }
        public int? Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public string Description { get; set; }
        public int HolidayType { get; set; }
    }
}
