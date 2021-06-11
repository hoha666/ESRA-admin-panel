using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RelationGameMarketListSelectMyBosses
    {
        public int GameMarketListId { get; set; }
        public int SelectMyBossesId { get; set; }
        public int? TableId { get; set; }
        public int? SubformId { get; set; }
        public int Id { get; set; }

        public GameMarketList GameMarketList { get; set; }
        public SelectMyBosses SelectMyBosses { get; set; }
    }
}
