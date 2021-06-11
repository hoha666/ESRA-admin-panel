using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class Documents
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int CreatorId { get; set; }
        public string RegistrationDate { get; set; }
        public string Description { get; set; }
        public int FolderId { get; set; }
        public string DocumentAccess { get; set; }
        public byte[] Data { get; set; }
    }
}
