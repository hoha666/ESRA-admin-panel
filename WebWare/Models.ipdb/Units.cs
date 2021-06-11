using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class Units
    {
        public Units()
        {
            Posts = new HashSet<Posts>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int OriginalUnit { get; set; }
        public bool AutomaticCoding { get; set; }
        public string LetterCode { get; set; }
        public string DocumentCode { get; set; }
        public int OrganizationId { get; set; }

        public Organizations1 Organization { get; set; }
        public ICollection<Posts> Posts { get; set; }
    }
}
