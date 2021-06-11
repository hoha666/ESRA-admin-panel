using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class GameTitleRegisterReq
    {
        public int Id { get; set; }
        public string TxtFirstName { get; set; }
        public string TxtSecondName { get; set; }
        public string CreatorGameTitleRegisterReq { get; set; }
        public string IpGameTitleRegisterReq { get; set; }
        public bool? RegistrationStatusGameTitleRegisterReq { get; set; }
        public string RegistrationDateGameTitleRegisterReq { get; set; }
        public string RegistrationTimeGameTitleRegisterReq { get; set; }
        public string AuditStatusGameTitleRegisterReq { get; set; }
        public string InstanceIdGameTitleRegisterReq { get; set; }
        public int? InstanceSridGameTitleRegisterReq { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
        public string DdlOrgDecide { get; set; }
        public string TxtCompanyName { get; set; }
    }
}
