using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class CorrespondenceDocumentAccesses
    {
        public int Id { get; set; }
        public string DocumentId { get; set; }
        public string PersonId { get; set; }
    }
}
