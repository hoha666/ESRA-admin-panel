using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblAccountType
    {
        public TblAccountType()
        {
            TblAccounts = new HashSet<TblAccounts>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? AccountTypeUnitId { get; set; }

        public ICollection<TblAccounts> TblAccounts { get; set; }
    }
}
