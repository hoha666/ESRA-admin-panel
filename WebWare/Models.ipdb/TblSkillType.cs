using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblSkillType
    {
        public TblSkillType()
        {
            TblVersionSkill = new HashSet<TblVersionSkill>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<TblVersionSkill> TblVersionSkill { get; set; }
    }
}
