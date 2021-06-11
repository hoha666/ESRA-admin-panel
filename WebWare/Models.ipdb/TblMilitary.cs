using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblMilitary
    {
        public TblMilitary()
        {
            TblProducerNexclusiveNuser = new HashSet<TblProducerNexclusiveNuser>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<TblProducerNexclusiveNuser> TblProducerNexclusiveNuser { get; set; }
    }
}
