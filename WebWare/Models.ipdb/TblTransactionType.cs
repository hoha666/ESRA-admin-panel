using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblTransactionType
    {
        public TblTransactionType()
        {
            TblTransaction = new HashSet<TblTransaction>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public string Abbreviation { get; set; }
        public bool IsIncrement { get; set; }

        public ICollection<TblTransaction> TblTransaction { get; set; }
    }
}
