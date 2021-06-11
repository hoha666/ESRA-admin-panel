using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class FormFields
    {
        public int Id { get; set; }
        public string FieldName { get; set; }
        public string ControlType { get; set; }
        public string ControlId { get; set; }
        public string Label { get; set; }
        public bool IsRequired { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }
        public bool ConnectToDatabase { get; set; }
        public string SourceTableName { get; set; }
        public string SourceFieldName { get; set; }
        public int FormTabId { get; set; }
        public int FormId { get; set; }
        public string Size { get; set; }
        public int? FilteringId { get; set; }
        public string SourceFieldValueName { get; set; }

        public Filterings Filtering { get; set; }
        public TableDetails TableDetails { get; set; }
    }
}
