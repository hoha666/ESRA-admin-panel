using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblProducerNexclusiveNuser
    {
        public TblProducerNexclusiveNuser()
        {
            TblAuctionParticipant = new HashSet<TblAuctionParticipant>();
            TblAuctionVote = new HashSet<TblAuctionVote>();
            TblAuctionWinner = new HashSet<TblAuctionWinner>();
            TblCertificationVersion = new HashSet<TblCertificationVersion>();
            TblConsultation = new HashSet<TblConsultation>();
            TblEditOffers = new HashSet<TblEditOffers>();
            TblFounderGroup = new HashSet<TblFounderGroup>();
            TblIranianPhysicalPublisherVersion = new HashSet<TblIranianPhysicalPublisherVersion>();
            TblItemVersions = new HashSet<TblItemVersions>();
            TblOrganizationBonyad = new HashSet<TblOrganizationBonyad>();
            TblPublishCertification = new HashSet<TblPublishCertification>();
            TblPublishCertificationValetIdUserEsraNavigation = new HashSet<TblPublishCertificationValet>();
            TblPublishCertificationValetIdUserNezaratNavigation = new HashSet<TblPublishCertificationValet>();
            TblStaticPage = new HashSet<TblStaticPage>();
            TblUserDocumentFile = new HashSet<TblUserDocumentFile>();
            TblVersion1IdAnalizorNavigation = new HashSet<TblVersion1>();
            TblVersion1IdGamerNavigation = new HashSet<TblVersion1>();
            TblVersion1IdNarratorNavigation = new HashSet<TblVersion1>();
            TblVersion1IdUserNavigation = new HashSet<TblVersion1>();
            TblVersionEsra1 = new HashSet<TblVersionEsra1>();
            TblVersionExclusive = new HashSet<TblVersionExclusive>();
            TblVersionPictogram = new HashSet<TblVersionPictogram>();
            TblVersionSkill = new HashSet<TblVersionSkill>();
        }

        public int Id { get; set; }
        public int? Type { get; set; }
        public int IdCountry { get; set; }
        public string WebSite { get; set; }
        public int IdOrganization { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public int? IdNezamVazife { get; set; }

        public TblCountry IdCountryNavigation { get; set; }
        public TblMilitary IdNezamVazifeNavigation { get; set; }
        public TblOrganizationBonyad IdOrganizationNavigation { get; set; }
        public ICollection<TblAuctionParticipant> TblAuctionParticipant { get; set; }
        public ICollection<TblAuctionVote> TblAuctionVote { get; set; }
        public ICollection<TblAuctionWinner> TblAuctionWinner { get; set; }
        public ICollection<TblCertificationVersion> TblCertificationVersion { get; set; }
        public ICollection<TblConsultation> TblConsultation { get; set; }
        public ICollection<TblEditOffers> TblEditOffers { get; set; }
        public ICollection<TblFounderGroup> TblFounderGroup { get; set; }
        public ICollection<TblIranianPhysicalPublisherVersion> TblIranianPhysicalPublisherVersion { get; set; }
        public ICollection<TblItemVersions> TblItemVersions { get; set; }
        public ICollection<TblOrganizationBonyad> TblOrganizationBonyad { get; set; }
        public ICollection<TblPublishCertification> TblPublishCertification { get; set; }
        public ICollection<TblPublishCertificationValet> TblPublishCertificationValetIdUserEsraNavigation { get; set; }
        public ICollection<TblPublishCertificationValet> TblPublishCertificationValetIdUserNezaratNavigation { get; set; }
        public ICollection<TblStaticPage> TblStaticPage { get; set; }
        public ICollection<TblUserDocumentFile> TblUserDocumentFile { get; set; }
        public ICollection<TblVersion1> TblVersion1IdAnalizorNavigation { get; set; }
        public ICollection<TblVersion1> TblVersion1IdGamerNavigation { get; set; }
        public ICollection<TblVersion1> TblVersion1IdNarratorNavigation { get; set; }
        public ICollection<TblVersion1> TblVersion1IdUserNavigation { get; set; }
        public ICollection<TblVersionEsra1> TblVersionEsra1 { get; set; }
        public ICollection<TblVersionExclusive> TblVersionExclusive { get; set; }
        public ICollection<TblVersionPictogram> TblVersionPictogram { get; set; }
        public ICollection<TblVersionSkill> TblVersionSkill { get; set; }
    }
}
