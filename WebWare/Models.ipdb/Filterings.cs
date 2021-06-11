using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class Filterings
    {
        public Filterings()
        {
            FormFields = new HashSet<FormFields>();
        }

        public int Id { get; set; }
        public int FormFieldId { get; set; }
        public int FormField2Id { get; set; }
        public string Value { get; set; }
        public string FilteringItem { get; set; }

        public ICollection<FormFields> FormFields { get; set; }
    }
}
