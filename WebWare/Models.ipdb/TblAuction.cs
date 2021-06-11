using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblAuction
    {
        public TblAuction()
        {
            TblAuctionItem = new HashSet<TblAuctionItem>();
            TblAuctionParticipant = new HashSet<TblAuctionParticipant>();
            TblAuctionVote = new HashSet<TblAuctionVote>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? Date { get; set; }
        public bool? IsActive { get; set; }
        public bool? AllPublishers { get; set; }

        public ICollection<TblAuctionItem> TblAuctionItem { get; set; }
        public ICollection<TblAuctionParticipant> TblAuctionParticipant { get; set; }
        public ICollection<TblAuctionVote> TblAuctionVote { get; set; }
    }
}
