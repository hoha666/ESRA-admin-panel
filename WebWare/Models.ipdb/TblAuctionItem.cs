using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblAuctionItem
    {
        public TblAuctionItem()
        {
            TblAuctionVote = new HashSet<TblAuctionVote>();
            TblAuctionWinner = new HashSet<TblAuctionWinner>();
            TblHologramInstalltion = new HashSet<TblHologramInstalltion>();
            TblItemVersions = new HashSet<TblItemVersions>();
        }

        public int Id { get; set; }
        public int? IdAuction { get; set; }
        public string Name { get; set; }
        public byte? ValidTime { get; set; }
        public bool? Monopoly { get; set; }

        public TblAuction IdAuctionNavigation { get; set; }
        public ICollection<TblAuctionVote> TblAuctionVote { get; set; }
        public ICollection<TblAuctionWinner> TblAuctionWinner { get; set; }
        public ICollection<TblHologramInstalltion> TblHologramInstalltion { get; set; }
        public ICollection<TblItemVersions> TblItemVersions { get; set; }
    }
}
