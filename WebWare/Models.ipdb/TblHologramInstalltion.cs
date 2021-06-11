using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblHologramInstalltion
    {
        public TblHologramInstalltion()
        {
            TblHologramInstallFail = new HashSet<TblHologramInstallFail>();
        }

        public int Id { get; set; }
        public int IdAuctionItem { get; set; }
        public int? Count { get; set; }
        public bool IsInstallOk { get; set; }
        public DateTime? DateTime { get; set; }

        public TblAuctionItem IdAuctionItemNavigation { get; set; }
        public ICollection<TblHologramInstallFail> TblHologramInstallFail { get; set; }
    }
}
