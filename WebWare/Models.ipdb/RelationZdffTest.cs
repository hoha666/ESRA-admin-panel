using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RelationZdffTest
    {
        public int Id { get; set; }
        public int? TestId { get; set; }
        public int? ZdffId { get; set; }
        public int? TableId { get; set; }
        public int? SubformId { get; set; }
    }
}
