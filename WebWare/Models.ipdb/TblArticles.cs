using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblArticles
    {
        public int Id { get; set; }
        public int ArticlesType { get; set; }
        public int ParticipantId { get; set; }
        public string Title { get; set; }
        public string Authors { get; set; }
        public int? FileId { get; set; }
    }
}
