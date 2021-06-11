using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblNezaratAuction
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int CreatorId { get; set; }
        public int? ResultFileId { get; set; }
        public int State { get; set; }
        public DateTime? StartAuctionDate { get; set; }
    }
}
