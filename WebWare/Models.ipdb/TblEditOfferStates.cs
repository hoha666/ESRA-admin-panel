using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblEditOfferStates
    {
        public TblEditOfferStates()
        {
            TblEditOffers = new HashSet<TblEditOffers>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<TblEditOffers> TblEditOffers { get; set; }
    }
}
