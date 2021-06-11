using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class MobileGameRatingResult
    {
        public int Id { get; set; }
        public string GamePic { get; set; }
        public string GameFname { get; set; }
        public string Result { get; set; }
        public string GameRating { get; set; }
        public string GameCode { get; set; }

        public GameMarketList IdNavigation { get; set; }
    }
}
