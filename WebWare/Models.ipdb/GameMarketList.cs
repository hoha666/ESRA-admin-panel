using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class GameMarketList
    {
        public GameMarketList()
        {
            RelationGameMarketListSelectMyBosses = new HashSet<RelationGameMarketListSelectMyBosses>();
        }

        public int Id { get; set; }
        public string TxtMarket { get; set; }
        public string CreatorGameMarketList { get; set; }
        public string IpGameMarketList { get; set; }
        public bool? RegistrationStatusGameMarketList { get; set; }
        public string RegistrationDateGameMarketList { get; set; }
        public string RegistrationTimeGameMarketList { get; set; }
        public string AuditStatusGameMarketList { get; set; }
        public string InstanceIdGameMarketList { get; set; }
        public int? InstanceSridGameMarketList { get; set; }

        public MobileGameRatingResult MobileGameRatingResult { get; set; }
        public ICollection<RelationGameMarketListSelectMyBosses> RelationGameMarketListSelectMyBosses { get; set; }
    }
}
