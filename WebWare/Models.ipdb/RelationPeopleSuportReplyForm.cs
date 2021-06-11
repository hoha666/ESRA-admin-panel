using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RelationPeopleSuportReplyForm
    {
        public int PeopleId { get; set; }
        public int SuportReplyFormId { get; set; }
        public int? TableId { get; set; }
        public int? SubformId { get; set; }
        public int Id { get; set; }

        public People People { get; set; }
        public SuportReplyForm SuportReplyForm { get; set; }
    }
}
