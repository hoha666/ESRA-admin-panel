using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class GamerVideo
    {
        public GamerVideo()
        {
            UploadFullGameVideo = new HashSet<UploadFullGameVideo>();
            VideoUpload = new HashSet<VideoUpload>();
        }

        public int Id { get; set; }
        public string CreatorGamerVideo { get; set; }
        public string IpGamerVideo { get; set; }
        public bool? RegistrationStatusGamerVideo { get; set; }
        public string RegistrationDateGamerVideo { get; set; }
        public string RegistrationTimeGamerVideo { get; set; }
        public string AuditStatusGamerVideo { get; set; }
        public string InstanceIdGamerVideo { get; set; }
        public int? InstanceSridGamerVideo { get; set; }

        public ICollection<UploadFullGameVideo> UploadFullGameVideo { get; set; }
        public ICollection<VideoUpload> VideoUpload { get; set; }
    }
}
