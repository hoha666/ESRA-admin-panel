using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class Indicators
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Format { get; set; }
        public string CreatorId { get; set; }
        public string AccessType { get; set; }
        public string Number { get; set; }
        public string LetterType { get; set; }
        public string Minimum { get; set; }
        public string Scale { get; set; }
        public string ScaleValue { get; set; }
    }
}
