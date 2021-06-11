using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblEditOffers
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int VersionId { get; set; }
        public int PriceOffer { get; set; }
        public string TimeOffer { get; set; }
        public int EditOfferStatesId { get; set; }

        public TblEditOfferStates EditOfferStates { get; set; }
        public TblProducerNexclusiveNuser User { get; set; }
        public TblVersion1 Version { get; set; }
    }
}
