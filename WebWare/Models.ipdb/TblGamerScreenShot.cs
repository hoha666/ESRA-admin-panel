using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblGamerScreenShot
    {
        public int IdSourceMedia { get; set; }
        public int IdFile { get; set; }
        public int? IdScreenShotType { get; set; }

        public TblFile1 IdFileNavigation { get; set; }
        public TblScreenshotType1 IdScreenShotTypeNavigation { get; set; }
        public TblSourceMedia IdSourceMediaNavigation { get; set; }
    }
}
