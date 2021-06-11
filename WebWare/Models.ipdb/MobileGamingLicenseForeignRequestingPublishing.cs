using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class MobileGamingLicenseForeignRequestingPublishing
    {
        public int Id { get; set; }
        public string TxtNameGame { get; set; }
        public string TxtSecondNameGame { get; set; }
        public string UplLegalRepresentation { get; set; }
        public string UplContractWthPublisher { get; set; }
        public string CreatorMobileGamingLicenseForeignRequestingPublishing { get; set; }
        public string IpMobileGamingLicenseForeignRequestingPublishing { get; set; }
        public bool? RegistrationStatusMobileGamingLicenseForeignRequestingPublishing { get; set; }
        public string RegistrationDateMobileGamingLicenseForeignRequestingPublishing { get; set; }
        public string RegistrationTimeMobileGamingLicenseForeignRequestingPublishing { get; set; }
        public string AuditStatusMobileGamingLicenseForeignRequestingPublishing { get; set; }
        public string InstanceIdMobileGamingLicenseForeignRequestingPublishing { get; set; }
        public int? InstanceSridMobileGamingLicenseForeignRequestingPublishing { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
        public string DdlDemandPlatform { get; set; }
        public string TxtVersionBelongsAndroid { get; set; }
        public string UplGameIcon { get; set; }
        public string UplUpload { get; set; }
        public string TxtDownloadLink { get; set; }
        public string TxtFilePassword { get; set; }
        public string UplIntroductionLetter { get; set; }
    }
}
