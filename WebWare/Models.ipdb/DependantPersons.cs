using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class DependantPersons
    {
        public int Id { get; set; }
        public int FileId { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string NationalCode { get; set; }
        public string IdentityNumber { get; set; }
        public string SeriesId { get; set; }
        public string IssuedPlace { get; set; }
        public string BirthDate { get; set; }
        public string Birthplace { get; set; }
        public bool Sex { get; set; }
        public string Relation { get; set; }
        public int PersonId { get; set; }

        public People Person { get; set; }
    }
}
