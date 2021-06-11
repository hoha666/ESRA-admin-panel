﻿using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class Objectives
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Field { get; set; }
        public string Index { get; set; }
        public string Description { get; set; }
        public int? TargetId { get; set; }

        public Targets Target { get; set; }
    }
}
