using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblVersionCategory
    {
        public int IdVersion { get; set; }
        public int IdCategory { get; set; }

        public TblGameCategory IdCategoryNavigation { get; set; }
        public TblVersion IdVersionNavigation { get; set; }
    }
}
