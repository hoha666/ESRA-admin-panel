using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class MobileGamesRatingRequest
    {
        public int Id { get; set; }
        public string DdlSendigType { get; set; }
        public string GameUpload { get; set; }
        public string TxtDownloadLink { get; set; }
        public string TxaGameHelp { get; set; }
        public string FileUpload { get; set; }
        public string CreatorMobileGamesRatingRequest { get; set; }
        public string IpMobileGamesRatingRequest { get; set; }
        public bool? RegistrationStatusMobileGamesRatingRequest { get; set; }
        public string RegistrationDateMobileGamesRatingRequest { get; set; }
        public string RegistrationTimeMobileGamesRatingRequest { get; set; }
        public string AuditStatusMobileGamesRatingRequest { get; set; }
        public string InstanceIdMobileGamesRatingRequest { get; set; }
        public string TxtGameName { get; set; }
        public string TxtGameLname { get; set; }
        public string DdlPlatform { get; set; }
        public int? TxtGameValue { get; set; }
        public string RdbPayment { get; set; }
        public string TxtProducter { get; set; }
        public string TxtGameVersion { get; set; }
        public int? InstanceSridMobileGamesRatingRequest { get; set; }
    }
}
