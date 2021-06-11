using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class WfwConditions
    {
        public int Id { get; set; }
        public int OperationId { get; set; }
        public int Result { get; set; }
        public string Tabel { get; set; }
        public string Field { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
        public bool IsNodeRecord { get; set; }
        public int? NodeRecordId { get; set; }
        public int NodeConditionId { get; set; }

        public WfwOperations Operation { get; set; }
    }
}
