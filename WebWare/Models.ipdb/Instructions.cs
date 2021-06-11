using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class Instructions
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ActivityTitle { get; set; }
        public string Goal { get; set; }
        public string ApplicationScope { get; set; }
        public int RelatedDocumentId { get; set; }
        public string Responsibility { get; set; }
        public string Procedure { get; set; }
        public string Description { get; set; }
    }
}
