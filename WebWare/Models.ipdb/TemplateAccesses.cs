using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TemplateAccesses
    {
        public int Id { get; set; }
        public string TemplateId { get; set; }
        public string PersonId { get; set; }
    }
}
