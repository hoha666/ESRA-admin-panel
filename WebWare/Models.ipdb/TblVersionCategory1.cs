using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblVersionCategory1
    {
        public int IdVersion { get; set; }
        public int IdCategory { get; set; }

        public TblGameCategory1 IdCategoryNavigation { get; set; }
        public TblVersion1 IdVersionNavigation { get; set; }
    }
}
