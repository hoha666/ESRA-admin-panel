using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblGamerScreenVideo
    {
        public int IdSourceMedia { get; set; }
        public int IdFile { get; set; }
        public int IdPictogramFirstLevel { get; set; }
        public int? IdScreenShotType { get; set; }
        public string GamerComment { get; set; }

        public TblFile1 IdFileNavigation { get; set; }
        public TblPictogram1 IdPictogramFirstLevelNavigation { get; set; }
        public TblScreenshotType1 IdScreenShotTypeNavigation { get; set; }
        public TblSourceMedia IdSourceMediaNavigation { get; set; }
    }
}
