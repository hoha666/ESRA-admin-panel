using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class Entities
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int DataModelGroupId { get; set; }
        public int? DataModelSubGroupId { get; set; }
    }
}
