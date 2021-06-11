using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblFestivalAward
    {
        public int Id { get; set; }
        public int FestivalId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int TypeId { get; set; }
        public int ParticipantId { get; set; }
        public string GameName { get; set; }
        public int? FileId { get; set; }
        public int? AwardId { get; set; }
    }
}
