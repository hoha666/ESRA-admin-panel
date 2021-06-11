using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class SubForms
    {
        public int Id { get; set; }
        public int FieldId { get; set; }
        public int FormId { get; set; }
        public int RowCount { get; set; }
        public string TsqlLaw { get; set; }
        public int MinSubmit { get; set; }
    }
}
