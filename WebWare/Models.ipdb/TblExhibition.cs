using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblExhibition
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string EventDate { get; set; }
        public int FileId { get; set; }
        public int TypeId { get; set; }
        public int ParticipantId { get; set; }
        public int? ExhibitionTypeId { get; set; }
    }
}
