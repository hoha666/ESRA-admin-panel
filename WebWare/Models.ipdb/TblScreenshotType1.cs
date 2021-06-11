using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblScreenshotType1
    {
        public TblScreenshotType1()
        {
            TblGamerScreenShot = new HashSet<TblGamerScreenShot>();
            TblGamerScreenVideo = new HashSet<TblGamerScreenVideo>();
            TblPublishCertificationValet = new HashSet<TblPublishCertificationValet>();
            TblVersionScreenshot1 = new HashSet<TblVersionScreenshot1>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<TblGamerScreenShot> TblGamerScreenShot { get; set; }
        public ICollection<TblGamerScreenVideo> TblGamerScreenVideo { get; set; }
        public ICollection<TblPublishCertificationValet> TblPublishCertificationValet { get; set; }
        public ICollection<TblVersionScreenshot1> TblVersionScreenshot1 { get; set; }
    }
}
