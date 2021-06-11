using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class Cartables
    {
        public int Id { get; set; }
        public string PersonId { get; set; }
        public string Access { get; set; }
        public string AccessType { get; set; }
        public string CreatorId { get; set; }
        public string RegistrationDate { get; set; }
    }
}
