using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblAccounts
    {
        public int Id { get; set; }
        public int AccountTypeId { get; set; }
        public int? OrganizationId { get; set; }
        public int? AccountStateId { get; set; }

        public TblAccountType AccountType { get; set; }
    }
}
