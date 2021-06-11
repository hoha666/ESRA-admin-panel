using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class PersonalInformations
    {
        public int Id { get; set; }
        public string FileId { get; set; }
        public int OrganizationalAge { get; set; }
        public string SeriesId { get; set; }
        public string IssuedPlace { get; set; }
        public string Birthplace { get; set; }
        public string BirthDate { get; set; }
        public string FatherName { get; set; }
        public string Nationality { get; set; }
        public string Religion { get; set; }
        public bool MaritalStatus { get; set; }
        public string Sacrifice { get; set; }
        public string Telephone { get; set; }
        public string Address { get; set; }
        public int PersonId { get; set; }

        public People Person { get; set; }
    }
}
