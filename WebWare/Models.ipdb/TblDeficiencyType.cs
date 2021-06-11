using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblDeficiencyType
    {
        public TblDeficiencyType()
        {
            TblHologramInstallFail = new HashSet<TblHologramInstallFail>();
            TblSourceMedia = new HashSet<TblSourceMedia>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public byte? Type { get; set; }

        public ICollection<TblHologramInstallFail> TblHologramInstallFail { get; set; }
        public ICollection<TblSourceMedia> TblSourceMedia { get; set; }
    }
}
