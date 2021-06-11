using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblScreenshotType
    {
        public TblScreenshotType()
        {
            TblVersionScreenshot = new HashSet<TblVersionScreenshot>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<TblVersionScreenshot> TblVersionScreenshot { get; set; }
    }
}
