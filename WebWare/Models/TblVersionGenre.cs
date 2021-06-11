using System;
using System.Collections.Generic;

namespace WebWare.Models
{
    public partial class TblVersionGenre
    {
        public int IdVersion { get; set; }
        public int IdGenre { get; set; }

        public TblCategory IdGenreNavigation { get; set; }
        public TblVersion IdVersionNavigation { get; set; }
    }
}
