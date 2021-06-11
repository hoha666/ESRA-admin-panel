using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblVersion
    {
        public TblVersion()
        {
            TblVersionCategory = new HashSet<TblVersionCategory>();
            TblVersionEsra = new HashSet<TblVersionEsra>();
            TblVersionGenre = new HashSet<TblVersionGenre>();
            TblVersionPictogram1 = new HashSet<TblVersionPictogram1>();
        }

        public int Id { get; set; }
        public DateTime? AddDate { get; set; }
        public string AnalizDuration { get; set; }
        public string GameDuration { get; set; }
        public string GamePlay { get; set; }
        public int? IdAnalizor { get; set; }
        public int? IdBasket { get; set; }
        public int IdEditableType { get; set; }
        public int? IdEditedVersion { get; set; }
        public int IdGame { get; set; }
        public int? IdGamer { get; set; }
        public int IdLanguage { get; set; }
        public int? IdNarrator { get; set; }
        public int? IdOrginalVersion { get; set; }
        public int IdPlatform { get; set; }
        public int IdProducer { get; set; }
        public int IdQuality { get; set; }
        public int IdSourceType { get; set; }
        public int IdUser { get; set; }
        public bool? InAppPayments { get; set; }
        public string Introduction { get; set; }
        public string IntroductionK1 { get; set; }
        public string IntroductionMin { get; set; }
        public bool? IsEdited { get; set; }
        public bool? IsPersian { get; set; }
        public bool? IsSourceAvailable { get; set; }
        public string Name { get; set; }
        public string OldId { get; set; }
        public string ParentRecommendation { get; set; }
        public DateTime? ReleaseDateTime { get; set; }
        public string VersionCode { get; set; }

        public TblGame IdGameNavigation { get; set; }
        public TblOrganizationBonyad1 IdProducerNavigation { get; set; }
        public TblSourceType IdSourceTypeNavigation { get; set; }
        public ICollection<TblVersionCategory> TblVersionCategory { get; set; }
        public ICollection<TblVersionEsra> TblVersionEsra { get; set; }
        public ICollection<TblVersionGenre> TblVersionGenre { get; set; }
        public ICollection<TblVersionPictogram1> TblVersionPictogram1 { get; set; }
    }
}
