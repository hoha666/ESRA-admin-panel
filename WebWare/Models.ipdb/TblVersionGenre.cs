using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblVersionGenre
    {
        public int IdVersion { get; set; }
        public int IdGenre { get; set; }

        public TblCategory1 IdGenreNavigation { get; set; }
        public TblVersion IdVersionNavigation { get; set; }
    }
}
