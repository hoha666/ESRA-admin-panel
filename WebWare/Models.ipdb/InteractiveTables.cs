using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class InteractiveTables
    {
        public int Id { get; set; }
        public string FileId { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public double Age { get; set; }
        public string BloodGroup { get; set; }
        public int PersonId { get; set; }
    }
}
