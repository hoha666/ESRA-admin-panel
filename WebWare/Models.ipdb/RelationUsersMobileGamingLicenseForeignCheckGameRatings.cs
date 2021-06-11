using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RelationUsersMobileGamingLicenseForeignCheckGameRatings
    {
        public int Id { get; set; }
        public int? MobileGamingLicenseForeignCheckGameRatingsId { get; set; }
        public int? UsersId { get; set; }
        public int? TableId { get; set; }
        public int? SubformId { get; set; }
    }
}
