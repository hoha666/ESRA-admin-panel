using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class ColorPortalSettings
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public int EventId { get; set; }
        public int UserId { get; set; }
    }
}
