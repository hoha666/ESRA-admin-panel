using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class FormTabs
    {
        public int Id { get; set; }
        public int FormId { get; set; }
        public int AppearanceOrder { get; set; }
        public int Rows { get; set; }
        public int Columns { get; set; }
        public string TabTitle { get; set; }
        public string TabName { get; set; }
        public string ButtonText { get; set; }
    }
}
