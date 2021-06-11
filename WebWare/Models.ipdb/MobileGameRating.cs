using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class MobileGameRating
    {
        public MobileGameRating()
        {
            MobileGameMarketLink = new HashSet<MobileGameMarketLink>();
        }

        public int Id { get; set; }
        public string TxtGameFname { get; set; }
        public string TxtGameLname { get; set; }
        public string DdlGameType { get; set; }
        public string TxtCheckingDate { get; set; }
        public string ChkGameGenre { get; set; }
        public string TxtContent { get; set; }
        public string DdlGameRating { get; set; }
        public string TxaComment { get; set; }
        public string TxtGameLink { get; set; }
        public string DdlResult { get; set; }
        public string CreatorMobileGameRating { get; set; }
        public string IpMobileGameRating { get; set; }
        public bool? RegistrationStatusMobileGameRating { get; set; }
        public string RegistrationDateMobileGameRating { get; set; }
        public string RegistrationTimeMobileGameRating { get; set; }
        public string AuditStatusMobileGameRating { get; set; }
        public string InstanceIdMobileGameRating { get; set; }
        public string GameCode { get; set; }
        public int? InstanceSridMobileGameRating { get; set; }
        public string IconUpload { get; set; }
        public string ScreenShotUpload { get; set; }

        public ICollection<MobileGameMarketLink> MobileGameMarketLink { get; set; }
    }
}
