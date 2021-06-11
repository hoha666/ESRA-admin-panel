using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblConsultation
    {
        public int Id { get; set; }
        public string QuestionerNameNfamily { get; set; }
        public string QuestionerEmail { get; set; }
        public string Question { get; set; }
        public DateTime? QuestionDateTime { get; set; }
        public string TrackingCode { get; set; }
        public string Answer { get; set; }
        public DateTime AnswerDateTime { get; set; }
        public int IdResponser { get; set; }

        public TblProducerNexclusiveNuser IdResponserNavigation { get; set; }
    }
}
