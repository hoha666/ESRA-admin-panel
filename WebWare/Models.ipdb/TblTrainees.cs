using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblTrainees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string KaraCode { get; set; }
        public string Task { get; set; }
        public int FileId { get; set; }
        public bool? IsEmployee { get; set; }
    }
}
