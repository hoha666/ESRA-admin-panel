using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RelationPictogram2WRadebandiSazmani
    {
        public int Id { get; set; }
        public int? WRadebandiSazmaniId { get; set; }
        public int? Pictogram2Id { get; set; }
        public int? TableId { get; set; }
        public int? SubformId { get; set; }
    }
}
