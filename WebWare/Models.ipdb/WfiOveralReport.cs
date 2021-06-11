using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class WfiOveralReport
    {
        public int Id { get; set; }
        public string CkReport { get; set; }
        public string DdlOwner { get; set; }
        public string CreatorWfiOveralReport { get; set; }
        public string IpWfiOveralReport { get; set; }
        public bool? RegistrationStatusWfiOveralReport { get; set; }
        public string RegistrationDateWfiOveralReport { get; set; }
        public string RegistrationTimeWfiOveralReport { get; set; }
        public string AuditStatusWfiOveralReport { get; set; }
        public string InstanceIdWfiOveralReport { get; set; }
        public int? InstanceSridWfiOveralReport { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
