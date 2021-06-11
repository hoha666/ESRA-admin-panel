using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblAnalizGamePart
    {
        public int IdVersionEsraStatusPictogram { get; set; }
        public int IdGamePart { get; set; }

        public TblGamePart IdGamePartNavigation { get; set; }
        public TblVersionAnaliz IdVersionEsraStatusPictogramNavigation { get; set; }
    }
}
