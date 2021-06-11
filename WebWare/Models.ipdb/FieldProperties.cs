using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class FieldProperties
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Properties { get; set; }
        public int FieldId { get; set; }
    }
}
