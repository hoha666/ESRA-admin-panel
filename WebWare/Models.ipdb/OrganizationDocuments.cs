using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class OrganizationDocuments
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int CreatorId { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Description { get; set; }
        public int FolderId { get; set; }
        public string DocumentAccess { get; set; }
        public byte[] Data { get; set; }
        public int? VisionId { get; set; }

        public Visions Vision { get; set; }
    }
}
