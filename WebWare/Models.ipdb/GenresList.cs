using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class GenresList
    {
        public int Id { get; set; }
        public string TxtGenre { get; set; }
        public string CreatorGenresList { get; set; }
        public string IpGenresList { get; set; }
        public bool? RegistrationStatusGenresList { get; set; }
        public string RegistrationDateGenresList { get; set; }
        public string RegistrationTimeGenresList { get; set; }
        public string AuditStatusGenresList { get; set; }
        public string InstanceIdGenresList { get; set; }
        public int? InstanceSridGenresList { get; set; }
    }
}
