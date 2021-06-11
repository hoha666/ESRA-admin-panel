using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblOrganizationBonyad1
    {
        public TblOrganizationBonyad1()
        {
            InverseIdForeignPublisherNavigation = new HashSet<TblOrganizationBonyad1>();
            TblGame = new HashSet<TblGame>();
            TblVersion = new HashSet<TblVersion>();
        }

        public int Id { get; set; }
        public bool Allowed { get; set; }
        public DateTime? BusinessLicensesExpireDateTime { get; set; }
        public int? DaneshBonyan { get; set; }
        public string EconomicCode { get; set; }
        public long? ExternalIncoming { get; set; }
        public int? IdCeo { get; set; }
        public int IdCountry { get; set; }
        public int? IdForeignPublisher { get; set; }
        public long? InternalIncoming { get; set; }
        public bool IsCommercial { get; set; }
        public string LicenseNumber { get; set; }
        public string LinkEmail { get; set; }
        public string LinkName { get; set; }
        public string LinkPhone { get; set; }
        public string ManagerPhone { get; set; }
        public string NationalId { get; set; }
        public int? NumberPartTime { get; set; }
        public int? NumberStaff { get; set; }
        public string PostalCode { get; set; }
        public DateTime? RegistrationDateTime { get; set; }
        public string RegistrationNumber { get; set; }
        public int? Type { get; set; }

        public TblOrganizationBonyad1 IdForeignPublisherNavigation { get; set; }
        public ICollection<TblOrganizationBonyad1> InverseIdForeignPublisherNavigation { get; set; }
        public ICollection<TblGame> TblGame { get; set; }
        public ICollection<TblVersion> TblVersion { get; set; }
    }
}
