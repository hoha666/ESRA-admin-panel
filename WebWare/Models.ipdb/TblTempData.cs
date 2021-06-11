using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblTempData
    {
        public int Id { get; set; }
        public int? InstanceId { get; set; }
        public string Value { get; set; }
        public string SecondValue { get; set; }
    }
}
