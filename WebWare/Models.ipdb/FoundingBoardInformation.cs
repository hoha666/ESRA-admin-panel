using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class FoundingBoardInformation
    {
        public int Id { get; set; }
        public string Flname { get; set; }
        public string Tel { get; set; }
        public string Address { get; set; }
        public string Ncpic { get; set; }
        public string Bcpic { get; set; }
        public string VeteranStatus { get; set; }
        public string VeteranPic { get; set; }
        public string EduPic { get; set; }
        public string CreatorFoundingBoardInformation { get; set; }
        public string IpFoundingBoardInformation { get; set; }
        public bool? RegistrationStatusFoundingBoardInformation { get; set; }
        public string RegistrationDateFoundingBoardInformation { get; set; }
        public string RegistrationTimeFoundingBoardInformation { get; set; }
        public string AuditStatusFoundingBoardInformation { get; set; }
        public string InstanceIdFoundingBoardInformation { get; set; }
        public int? InstanceSridFoundingBoardInformation { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }

        public PepgameLicenseRequest ParentRecord { get; set; }
    }
}
