using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class ReportSettings
    {
        public int Id { get; set; }
        public string TableHeaderBackColor { get; set; }
        public string TableHeaderColor { get; set; }
        public string TableColor { get; set; }
        public string TableBackColor { get; set; }
        public string Title { get; set; }
        public string TitleFont { get; set; }
        public int TitleFontSize { get; set; }
        public string TableHeaderFont { get; set; }
        public string TableFont { get; set; }
        public int TableHeaderFontSize { get; set; }
        public int TableFontSize { get; set; }
    }
}
