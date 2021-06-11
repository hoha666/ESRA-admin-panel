using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class Attributes
    {
        public int Id { get; set; }
        public int EntityId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public bool IsAutoIncrement { get; set; }
        public string ColType { get; set; }
        public bool IsNullable { get; set; }
    }
}
