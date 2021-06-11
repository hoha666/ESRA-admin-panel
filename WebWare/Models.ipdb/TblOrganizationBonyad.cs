using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblOrganizationBonyad
    {
        public TblOrganizationBonyad()
        {
            InverseIdForeignPublisherNavigation = new HashSet<TblOrganizationBonyad>();
            RelationTblOrganizationBonyadSubmitSource = new HashSet<RelationTblOrganizationBonyadSubmitSource>();
            TblCompanyAriaActivity = new HashSet<TblCompanyAriaActivity>();
            TblFounderGroup = new HashSet<TblFounderGroup>();
            TblGame1 = new HashSet<TblGame1>();
            TblOrganizationBonyadFile = new HashSet<TblOrganizationBonyadFile>();
            TblProducerNexclusiveNuser = new HashSet<TblProducerNexclusiveNuser>();
            TblVersion1 = new HashSet<TblVersion1>();
        }

        public int Id { get; set; }
        public string RegistrationNumber { get; set; }
        public DateTime? RegistrationDateTime { get; set; }
        public int IdCountry { get; set; }
        public int? IdCeo { get; set; }
        public string NationalId { get; set; }
        public DateTime? BusinessLicensesExpireDateTime { get; set; }
        public string PostalCode { get; set; }
        public bool Allowed { get; set; }
        public int? IdForeignPublisher { get; set; }
        public bool IsCommercial { get; set; }
        public int? Type { get; set; }
        public string LicenseNumber { get; set; }
        public string EconomicCode { get; set; }
        public string ManagerPhone { get; set; }
        public int? NumberStaff { get; set; }
        public int? NumberPartTime { get; set; }
        public string LinkName { get; set; }
        public string LinkPhone { get; set; }
        public string LinkEmail { get; set; }
        public long? InternalIncoming { get; set; }
        public long? ExternalIncoming { get; set; }
        public int? DaneshBonyan { get; set; }
        public double? Vasincoming { get; set; }

        public TblProducerNexclusiveNuser IdCeoNavigation { get; set; }
        public TblCountry IdCountryNavigation { get; set; }
        public TblOrganizationBonyad IdForeignPublisherNavigation { get; set; }
        public TblOrgType TypeNavigation { get; set; }
        public ICollection<TblOrganizationBonyad> InverseIdForeignPublisherNavigation { get; set; }
        public ICollection<RelationTblOrganizationBonyadSubmitSource> RelationTblOrganizationBonyadSubmitSource { get; set; }
        public ICollection<TblCompanyAriaActivity> TblCompanyAriaActivity { get; set; }
        public ICollection<TblFounderGroup> TblFounderGroup { get; set; }
        public ICollection<TblGame1> TblGame1 { get; set; }
        public ICollection<TblOrganizationBonyadFile> TblOrganizationBonyadFile { get; set; }
        public ICollection<TblProducerNexclusiveNuser> TblProducerNexclusiveNuser { get; set; }
        public ICollection<TblVersion1> TblVersion1 { get; set; }
    }
}
