using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class Notes
    {
        public int Id { get; set; }
        public string Context { get; set; }
        public string LetterId { get; set; }
        public string ParentLetterId { get; set; }
        public string WriterId { get; set; }
        public string Date { get; set; }
        public string DateTime { get; set; }
        public string NoteAccess { get; set; }
    }
}
