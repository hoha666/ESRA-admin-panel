using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RelationUsersHoldingDisseminationRecordResults
    {
        public int Id { get; set; }
        public int? HoldingDisseminationRecordResultsId { get; set; }
        public int? UsersId { get; set; }
        public int? TableId { get; set; }
        public int? SubformId { get; set; }
    }
}
