using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblTeams
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Logo { get; set; }
        public string Address { get; set; }
        public string NameLink { get; set; }
        public string PhoneLink { get; set; }
        public string EmailLink { get; set; }
        public int? NumMember { get; set; }
        public long? Incoming { get; set; }
        public int? IncomingFileId { get; set; }
        public bool? IsVas { get; set; }
        public long? Vas { get; set; }
        public int? VasfileId { get; set; }
        public bool? IsOutcoming { get; set; }
        public long? Outcoming { get; set; }
        public int? OutcomingFileId { get; set; }
        public int? OrgId { get; set; }
    }
}
