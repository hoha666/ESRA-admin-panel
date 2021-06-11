using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class EmailAddresses
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string SmtpServer { get; set; }
        public int SmptPort { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool EnableSsl { get; set; }
        public bool IsActiveServer { get; set; }
    }
}
