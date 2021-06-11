using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblCountry
    {
        public TblCountry()
        {
            TblOrganizationBonyad = new HashSet<TblOrganizationBonyad>();
            TblProducerNexclusiveNuser = new HashSet<TblProducerNexclusiveNuser>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string LocalName { get; set; }
        public string RegionalCode { get; set; }

        public ICollection<TblOrganizationBonyad> TblOrganizationBonyad { get; set; }
        public ICollection<TblProducerNexclusiveNuser> TblProducerNexclusiveNuser { get; set; }
    }
}
