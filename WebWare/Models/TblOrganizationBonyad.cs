using System;
using System.Collections.Generic;

namespace WebWare.Models
{
    public partial class TblOrganizationBonyad
    {
        public TblOrganizationBonyad()
        {
            InverseIdForeignPublisherNavigation = new HashSet<TblOrganizationBonyad>();
            TblGame = new HashSet<TblGame>();
            TblVersion = new HashSet<TblVersion>();
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

        public TblOrganizationBonyad IdForeignPublisherNavigation { get; set; }
        public ICollection<TblOrganizationBonyad> InverseIdForeignPublisherNavigation { get; set; }
        public ICollection<TblGame> TblGame { get; set; }
        public ICollection<TblVersion> TblVersion { get; set; }
    }
}
