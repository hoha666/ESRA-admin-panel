using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class ChartSettings
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string BackColor { get; set; }
        public string Color { get; set; }
        public string TitelFont { get; set; }
        public int TitelFontSize { get; set; }
        public bool ShowValue { get; set; }
        public bool ShowYvalue { get; set; }
        public int ValueType { get; set; }
    }
}
