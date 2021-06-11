using System;
using System.Collections.Generic;

namespace WebWare.Models
{
    public partial class Organizations
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public int Parent { get; set; }
        public bool AutomaticCoding { get; set; }
        public string LetterCode { get; set; }
        public string DocumentCode { get; set; }
        public string FieldOfWork { get; set; }
        public string Manager { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public string Mobilephone { get; set; }
        public string Website { get; set; }
        public string Mail { get; set; }
        public string Address { get; set; }
        public string PostBox { get; set; }
        public bool IsMyOrganization { get; set; }
        public string Logo { get; set; }
        public string Document { get; set; }
    }
}
