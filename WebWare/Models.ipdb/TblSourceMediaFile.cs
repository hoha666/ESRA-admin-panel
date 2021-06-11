using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblSourceMediaFile
    {
        public int IdSourceMedia { get; set; }
        public int IdFile { get; set; }

        public TblFile1 IdFileNavigation { get; set; }
        public TblSourceMedia IdSourceMediaNavigation { get; set; }
    }
}
