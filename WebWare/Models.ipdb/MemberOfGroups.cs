using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class MemberOfGroups
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int PersonId { get; set; }
    }
}
