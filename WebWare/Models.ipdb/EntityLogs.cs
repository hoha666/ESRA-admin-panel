using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class EntityLogs
    {
        public Guid Id { get; set; }
        public string EntityName { get; set; }
        public string PrimaryKeyValue { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string Values { get; set; }
    }
}
