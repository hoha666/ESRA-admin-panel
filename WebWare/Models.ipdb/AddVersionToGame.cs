using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class AddVersionToGame
    {
        public int Id { get; set; }
        public string TxtVersionName { get; set; }
        public string DdlIsEdited { get; set; }
        public string DdlPlatform { get; set; }
        public string DdlIsOriginal { get; set; }
        public string DdlGenres { get; set; }
        public string DateReleaseDate { get; set; }
        public string TxtCompany { get; set; }
        public string CreatorAddVersionToGame { get; set; }
        public string IpAddVersionToGame { get; set; }
        public bool? RegistrationStatusAddVersionToGame { get; set; }
        public string RegistrationDateAddVersionToGame { get; set; }
        public string RegistrationTimeAddVersionToGame { get; set; }
        public string AuditStatusAddVersionToGame { get; set; }
        public string InstanceIdAddVersionToGame { get; set; }
        public int? InstanceSridAddVersionToGame { get; set; }
        public string DdlIranCompany { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
        public string DdlIsPersian { get; set; }
        public string DatePdate { get; set; }
        public DateTime? DatePdateGregorian { get; set; }
    }
}
