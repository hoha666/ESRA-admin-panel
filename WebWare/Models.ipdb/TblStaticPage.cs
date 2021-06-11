using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblStaticPage
    {
        public TblStaticPage()
        {
            TblStaticPageFile = new HashSet<TblStaticPageFile>();
            TblTag = new HashSet<TblTag>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string TitlePictureUrl { get; set; }
        public string Intro { get; set; }
        public string Content { get; set; }
        public DateTime CreationDateTime { get; set; }
        public int IdAuthor { get; set; }
        public string ReadMoreLink { get; set; }
        public bool? IsEdited { get; set; }
        public bool? IsDeleted { get; set; }
        public int? IdNewStaticPage { get; set; }

        public TblProducerNexclusiveNuser IdAuthorNavigation { get; set; }
        public ICollection<TblStaticPageFile> TblStaticPageFile { get; set; }
        public ICollection<TblTag> TblTag { get; set; }
    }
}
