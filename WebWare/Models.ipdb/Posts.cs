using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class Posts
    {
        public Posts()
        {
            PostPeoples = new HashSet<PostPeoples>();
        }

        public int Id { get; set; }
        public int OriginalPost { get; set; }
        public string Name { get; set; }
        public int PostCategoryId { get; set; }
        public bool AutomaticCoding { get; set; }
        public string LetterCode { get; set; }
        public int UnitId { get; set; }
        public string Description { get; set; }

        public Units Unit { get; set; }
        public ICollection<PostPeoples> PostPeoples { get; set; }
    }
}
