using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class MenuSettings
    {
        public int Id { get; set; }
        public string HorizontalParentUlId { get; set; }
        public string HorizontalParentUlClass { get; set; }
        public string HorizontalParentLiClass { get; set; }
        public string HorizontalChildUlClass { get; set; }
        public string HorizontalChildLiClass { get; set; }
        public string VerticalParentUlId { get; set; }
        public string VerticalParentUlClass { get; set; }
        public string VerticalParentLiClass { get; set; }
        public string VerticalChildUlClass { get; set; }
        public string VerticalChildLiClass { get; set; }
        public bool ShowToggleIcon { get; set; }
    }
}
