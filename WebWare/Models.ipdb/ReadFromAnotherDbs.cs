using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class ReadFromAnotherDbs
    {
        public int Id { get; set; }
        public string DbAddress { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string RecordField { get; set; }
        public string Description { get; set; }

        public NodeDetails IdNavigation { get; set; }
    }
}
