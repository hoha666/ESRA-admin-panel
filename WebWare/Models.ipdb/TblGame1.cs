using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblGame1
    {
        public TblGame1()
        {
            TblVersion1 = new HashSet<TblVersion1>();
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
        public ICollection<TblVersion1> TblVersion1 { get; set; }
    }
}
