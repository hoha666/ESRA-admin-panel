using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblStaticPageFile
    {
        public int IdStaticPage { get; set; }
        public int IdFile { get; set; }

        public TblFile1 IdFileNavigation { get; set; }
        public TblStaticPage IdStaticPageNavigation { get; set; }
    }
}
