using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblVersionAnaliz
    {
        public TblVersionAnaliz()
        {
            TblAnalizGamePart = new HashSet<TblAnalizGamePart>();
        }

        public int Id { get; set; }
        public int? IdVersion { get; set; }
        public int? IdPictogram { get; set; }
        public int? IdRate { get; set; }
        public string Title { get; set; }
        public string OccurredTime { get; set; }
        public string AnalizorComment { get; set; }
        public bool? GoEdit { get; set; }
        public int? IdFile { get; set; }
        public int? IdGamePart { get; set; }

        public TblFile1 IdFileNavigation { get; set; }
        public TblGamePart IdGamePartNavigation { get; set; }
        public TblPictogram1 IdPictogramNavigation { get; set; }
        public TblRate IdRateNavigation { get; set; }
        public TblVersion1 IdVersionNavigation { get; set; }
        public ICollection<TblAnalizGamePart> TblAnalizGamePart { get; set; }
    }
}
