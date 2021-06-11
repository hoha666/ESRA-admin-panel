using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RelationTestTableGtblTest
    {
        public int Id { get; set; }
        public int? GtblTestId { get; set; }
        public int? TestTableId { get; set; }
        public int? TableId { get; set; }
        public int? SubformId { get; set; }
    }
}
