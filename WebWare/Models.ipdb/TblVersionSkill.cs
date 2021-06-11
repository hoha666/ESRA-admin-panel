using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblVersionSkill
    {
        public int IdSkillType { get; set; }
        public int IdVersion { get; set; }
        public int IdUser { get; set; }
        public bool IsSuggestion { get; set; }
        public int? Rate { get; set; }

        public TblSkillType IdSkillTypeNavigation { get; set; }
        public TblProducerNexclusiveNuser IdUserNavigation { get; set; }
        public TblVersion1 IdVersionNavigation { get; set; }
    }
}
