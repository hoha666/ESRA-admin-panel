using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class Visions
    {
        public Visions()
        {
            OrganizationDocuments = new HashSet<OrganizationDocuments>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Field { get; set; }
        public string Horizon { get; set; }
        public int OrganizationDocumentId { get; set; }
        public string Description { get; set; }

        public ICollection<OrganizationDocuments> OrganizationDocuments { get; set; }
    }
}
