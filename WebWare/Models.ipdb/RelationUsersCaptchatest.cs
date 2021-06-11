using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RelationUsersCaptchatest
    {
        public int Id { get; set; }
        public int? CaptchatestId { get; set; }
        public int? UsersId { get; set; }
        public int? TableId { get; set; }
        public int? SubformId { get; set; }
    }
}
