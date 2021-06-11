using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblFile1
    {
        public TblFile1()
        {
            TblGamerScreenShot = new HashSet<TblGamerScreenShot>();
            TblGamerScreenVideo = new HashSet<TblGamerScreenVideo>();
            TblIndependentGameCreatorFile = new HashSet<TblIndependentGameCreatorFile>();
            TblOrganizationBonyadFile = new HashSet<TblOrganizationBonyadFile>();
            TblPublishCertificationValet = new HashSet<TblPublishCertificationValet>();
            TblSourceMediaFile = new HashSet<TblSourceMediaFile>();
            TblStaticPageFile = new HashSet<TblStaticPageFile>();
            TblUserDocumentFile = new HashSet<TblUserDocumentFile>();
            TblVersionAnaliz = new HashSet<TblVersionAnaliz>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public DateTime UploadDateTime { get; set; }
        public string FileType { get; set; }

        public ICollection<TblGamerScreenShot> TblGamerScreenShot { get; set; }
        public ICollection<TblGamerScreenVideo> TblGamerScreenVideo { get; set; }
        public ICollection<TblIndependentGameCreatorFile> TblIndependentGameCreatorFile { get; set; }
        public ICollection<TblOrganizationBonyadFile> TblOrganizationBonyadFile { get; set; }
        public ICollection<TblPublishCertificationValet> TblPublishCertificationValet { get; set; }
        public ICollection<TblSourceMediaFile> TblSourceMediaFile { get; set; }
        public ICollection<TblStaticPageFile> TblStaticPageFile { get; set; }
        public ICollection<TblUserDocumentFile> TblUserDocumentFile { get; set; }
        public ICollection<TblVersionAnaliz> TblVersionAnaliz { get; set; }
    }
}
