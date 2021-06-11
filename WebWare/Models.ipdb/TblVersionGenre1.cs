using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblVersionGenre1
    {
        public int IdVersion { get; set; }
        public int IdGenre { get; set; }

        public TblCategory IdGenreNavigation { get; set; }
        public TblVersion1 IdVersionNavigation { get; set; }
    }
}
