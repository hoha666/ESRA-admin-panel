using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblFile
    {
        public int Id { get; set; }
        public string FileType { get; set; }
        public string Name { get; set; }
        public DateTime UploadDateTime { get; set; }
        public string Url { get; set; }
    }
}
