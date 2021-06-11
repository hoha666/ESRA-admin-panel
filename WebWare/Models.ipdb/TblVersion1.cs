using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblVersion1
    {
        public TblVersion1()
        {
            TblCertificationVersion = new HashSet<TblCertificationVersion>();
            TblEditOffers = new HashSet<TblEditOffers>();
            TblIranianPhysicalPublisherVersion = new HashSet<TblIranianPhysicalPublisherVersion>();
            TblItemVersions = new HashSet<TblItemVersions>();
            TblPhysicalPublishLicenseVersions = new HashSet<TblPhysicalPublishLicenseVersions>();
            TblSourceMedia = new HashSet<TblSourceMedia>();
            TblVersionAnaliz = new HashSet<TblVersionAnaliz>();
            TblVersionCategory1 = new HashSet<TblVersionCategory1>();
            TblVersionEsra1 = new HashSet<TblVersionEsra1>();
            TblVersionExclusive = new HashSet<TblVersionExclusive>();
            TblVersionGenre1 = new HashSet<TblVersionGenre1>();
            TblVersionPictogram = new HashSet<TblVersionPictogram>();
            TblVersionSkill = new HashSet<TblVersionSkill>();
            TblVersionViewAngle = new HashSet<TblVersionViewAngle>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int IdPlatform { get; set; }
        public bool? IsSourceAvailable { get; set; }
        public int IdSourceType { get; set; }
        public int IdGame { get; set; }
        public DateTime? ReleaseDateTime { get; set; }
        public string Introduction { get; set; }
        public string IntroductionK1 { get; set; }
        public string GamePlay { get; set; }
        public string ParentRecommendation { get; set; }
        public int IdQuality { get; set; }
        public int IdProducer { get; set; }
        public int IdEditableType { get; set; }
        public int IdLanguage { get; set; }
        public bool? IsPersian { get; set; }
        public bool? IsEdited { get; set; }
        public string OldId { get; set; }
        public string IntroductionMin { get; set; }
        public bool? InAppPayments { get; set; }
        public int IdUser { get; set; }
        public int? IdNarrator { get; set; }
        public int? IdGamer { get; set; }
        public int? IdAnalizor { get; set; }
        public string GameDuration { get; set; }
        public string AnalizDuration { get; set; }
        public int? IdEditedVersion { get; set; }
        public int? IdOrginalVersion { get; set; }
        public DateTime? AddDate { get; set; }
        public int? IdBasket { get; set; }
        public string VersionCode { get; set; }

        public TblProducerNexclusiveNuser IdAnalizorNavigation { get; set; }
        public TblEditableType IdEditableTypeNavigation { get; set; }
        public TblGame1 IdGameNavigation { get; set; }
        public TblProducerNexclusiveNuser IdGamerNavigation { get; set; }
        public TblLanguage IdLanguageNavigation { get; set; }
        public TblProducerNexclusiveNuser IdNarratorNavigation { get; set; }
        public TblOrganizationBonyad IdProducerNavigation { get; set; }
        public TblQuality IdQualityNavigation { get; set; }
        public TblSourceType1 IdSourceTypeNavigation { get; set; }
        public TblProducerNexclusiveNuser IdUserNavigation { get; set; }
        public TblVersionNarrat TblVersionNarrat { get; set; }
        public ICollection<TblCertificationVersion> TblCertificationVersion { get; set; }
        public ICollection<TblEditOffers> TblEditOffers { get; set; }
        public ICollection<TblIranianPhysicalPublisherVersion> TblIranianPhysicalPublisherVersion { get; set; }
        public ICollection<TblItemVersions> TblItemVersions { get; set; }
        public ICollection<TblPhysicalPublishLicenseVersions> TblPhysicalPublishLicenseVersions { get; set; }
        public ICollection<TblSourceMedia> TblSourceMedia { get; set; }
        public ICollection<TblVersionAnaliz> TblVersionAnaliz { get; set; }
        public ICollection<TblVersionCategory1> TblVersionCategory1 { get; set; }
        public ICollection<TblVersionEsra1> TblVersionEsra1 { get; set; }
        public ICollection<TblVersionExclusive> TblVersionExclusive { get; set; }
        public ICollection<TblVersionGenre1> TblVersionGenre1 { get; set; }
        public ICollection<TblVersionPictogram> TblVersionPictogram { get; set; }
        public ICollection<TblVersionSkill> TblVersionSkill { get; set; }
        public ICollection<TblVersionViewAngle> TblVersionViewAngle { get; set; }
    }
}
