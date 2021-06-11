using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class Laws
    {
        public Laws()
        {
            Conditions = new HashSet<Conditions>();
            Operations = new HashSet<Operations>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int FormDetailId { get; set; }
        public string Gate { get; set; }

        public FormDetails FormDetail { get; set; }
        public ICollection<Conditions> Conditions { get; set; }
        public ICollection<Operations> Operations { get; set; }
    }
}
