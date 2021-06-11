using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblSourceMedia
    {
        public TblSourceMedia()
        {
            TblGamerScreenShot = new HashSet<TblGamerScreenShot>();
            TblGamerScreenVideo = new HashSet<TblGamerScreenVideo>();
            TblSourceMediaFile = new HashSet<TblSourceMediaFile>();
        }

        public int Id { get; set; }
        public int IdVersion { get; set; }
        public string Location { get; set; }
        public int IdSourceMediaType { get; set; }
        public int IdSourceMediaSentType { get; set; }
        public bool IsDoc { get; set; }
        public string Description { get; set; }
        public string GamerComment { get; set; }
        public int? IdDeficiencyType { get; set; }
        public string DeficiencyText { get; set; }

        public TblDeficiencyType IdDeficiencyTypeNavigation { get; set; }
        public TblSourceMediaSentType IdSourceMediaSentTypeNavigation { get; set; }
        public TblSourceMediaType IdSourceMediaTypeNavigation { get; set; }
        public TblVersion1 IdVersionNavigation { get; set; }
        public ICollection<TblGamerScreenShot> TblGamerScreenShot { get; set; }
        public ICollection<TblGamerScreenVideo> TblGamerScreenVideo { get; set; }
        public ICollection<TblSourceMediaFile> TblSourceMediaFile { get; set; }
    }
}
