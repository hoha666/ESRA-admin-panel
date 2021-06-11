using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblViewAngleType
    {
        public TblViewAngleType()
        {
            TblVersionViewAngle = new HashSet<TblVersionViewAngle>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<TblVersionViewAngle> TblVersionViewAngle { get; set; }
    }
}
