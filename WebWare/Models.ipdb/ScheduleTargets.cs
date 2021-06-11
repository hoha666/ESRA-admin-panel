using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class ScheduleTargets
    {
        public ScheduleTargets()
        {
            Indices = new HashSet<Indices>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Initialvalue { get; set; }
        public string Finalvalue { get; set; }
        public string Initialtime { get; set; }
        public string Filneltime { get; set; }
        public string Updating { get; set; }
        public int IndexId { get; set; }

        public ICollection<Indices> Indices { get; set; }
    }
}
