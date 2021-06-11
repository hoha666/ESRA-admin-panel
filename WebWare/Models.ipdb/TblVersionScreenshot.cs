using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblVersionScreenshot
    {
        public int IdVersion { get; set; }
        public int IdFile { get; set; }
        public int IdScreenshotType { get; set; }

        public TblScreenshotType IdScreenshotTypeNavigation { get; set; }
    }
}
