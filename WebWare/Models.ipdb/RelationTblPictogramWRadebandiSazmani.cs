using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RelationTblPictogramWRadebandiSazmani
    {
        public int Id { get; set; }
        public int? WRadebandiSazmaniId { get; set; }
        public int? TblPictogramId { get; set; }
        public int? TableId { get; set; }
        public int? SubformId { get; set; }
    }
}
