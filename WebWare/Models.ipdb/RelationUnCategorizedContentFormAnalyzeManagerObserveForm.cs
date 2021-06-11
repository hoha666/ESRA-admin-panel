using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RelationUnCategorizedContentFormAnalyzeManagerObserveForm
    {
        public int Id { get; set; }
        public int? AnalyzeManagerObserveFormId { get; set; }
        public int? UnCategorizedContentFormId { get; set; }
        public int? TableId { get; set; }
        public int? SubformId { get; set; }
    }
}
