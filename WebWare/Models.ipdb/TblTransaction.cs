using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblTransaction
    {
        public int Id { get; set; }
        public int IdTransactionType { get; set; }
        public int IdSourceAccount { get; set; }
        public int? IdDestinationAccount { get; set; }
        public int? IdProcessInBpms { get; set; }
        public int? IdConfirmerUser { get; set; }
        public int? IdFile { get; set; }
        public DateTime? Datetime { get; set; }
        public string Description { get; set; }
        public int? Value { get; set; }

        public TblTransactionType IdTransactionTypeNavigation { get; set; }
    }
}
