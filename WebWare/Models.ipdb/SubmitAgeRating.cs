using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class SubmitAgeRating
    {
        public int Id { get; set; }
        public string Result { get; set; }
        public string Comment { get; set; }
        public string CreatorSubmitAgeRating { get; set; }
        public string IpSubmitAgeRating { get; set; }
        public bool? RegistrationStatusSubmitAgeRating { get; set; }
        public string RegistrationDateSubmitAgeRating { get; set; }
        public string RegistrationTimeSubmitAgeRating { get; set; }
        public string AuditStatusSubmitAgeRating { get; set; }
        public string InstanceIdSubmitAgeRating { get; set; }
        public int? InstanceSridSubmitAgeRating { get; set; }
        public string AgeRating { get; set; }
    }
}
