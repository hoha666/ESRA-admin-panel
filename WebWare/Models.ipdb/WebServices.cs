using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class WebServices
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string MethodName { get; set; }
        public string ParametersTsql { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public NodeDetails IdNavigation { get; set; }
    }
}
