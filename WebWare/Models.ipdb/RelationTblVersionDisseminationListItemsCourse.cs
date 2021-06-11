using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RelationTblVersionDisseminationListItemsCourse
    {
        public int Id { get; set; }
        public int? DisseminationListItemsCourseId { get; set; }
        public int? TblVersionId { get; set; }
        public int? TableId { get; set; }
        public int? SubformId { get; set; }
    }
}
