using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class GamesGid
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string Producer { get; set; }
        public DateTime ProduceDate { get; set; }
        public string Gid { get; set; }
    }
}
