using System;
using System.Collections.Generic;

namespace WebWare.Models
{
    public partial class TblGame
    {
        public TblGame()
        {
            TblVersion = new HashSet<TblVersion>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int IdProducer { get; set; }
        public string Name2 { get; set; }
        public DateTime PublishDateTime { get; set; }
        public bool? IsOnline { get; set; }
        public string WebSite { get; set; }
        public bool? ShowInEsraWebsite { get; set; }
        public bool? IsInIntroduction { get; set; }

        public TblOrganizationBonyad IdProducerNavigation { get; set; }
        public ICollection<TblVersion> TblVersion { get; set; }
    }
}
