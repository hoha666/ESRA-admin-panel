﻿using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RelationTblVersionSur030CheckExistenceVersion
    {
        public int Id { get; set; }
        public int? Sur030CheckExistenceVersionId { get; set; }
        public int? TblVersionId { get; set; }
        public int? TableId { get; set; }
        public int? SubformId { get; set; }
    }
}
