using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class Mlogs
    {
        public Guid Id { get; set; }
        public Guid? ParentId { get; set; }
        public string Title { get; set; }
        public int Type { get; set; }
        public string Source { get; set; }
        public string TargetSite { get; set; }
        public string Body { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime SavedTime { get; set; }
        public string Comment { get; set; }
        public string AdditionalData { get; set; }
        public string Tag { get; set; }
    }
}
