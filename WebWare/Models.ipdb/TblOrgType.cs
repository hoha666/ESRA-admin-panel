using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblOrgType
    {
        public TblOrgType()
        {
            TblOrganizationBonyad = new HashSet<TblOrganizationBonyad>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<TblOrganizationBonyad> TblOrganizationBonyad { get; set; }
    }
}
