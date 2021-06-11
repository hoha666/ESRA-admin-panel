using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class PostPeoples
    {
        public int Id { get; set; }
        public int PeopleId { get; set; }
        public int UnitId { get; set; }
        public int PostId { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public bool Status { get; set; }
        public bool CartableStatus { get; set; }
        public string CartableViewDate { get; set; }
        public bool IsDefault { get; set; }

        public People People { get; set; }
        public Posts Post { get; set; }
    }
}
