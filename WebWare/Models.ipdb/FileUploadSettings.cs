using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class FileUploadSettings
    {
        public int Id { get; set; }
        public string FolderName { get; set; }
        public int FieldId { get; set; }
        public string AcceptableExtensions { get; set; }
        public int MinSizeInKb { get; set; }
        public int MaxSizeInKb { get; set; }
    }
}
