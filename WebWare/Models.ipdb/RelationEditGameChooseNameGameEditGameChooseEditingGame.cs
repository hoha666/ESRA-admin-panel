using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class RelationEditGameChooseNameGameEditGameChooseEditingGame
    {
        public int Id { get; set; }
        public int? EditGameChooseEditingGameId { get; set; }
        public int? EditGameChooseNameGameId { get; set; }
        public int? TableId { get; set; }
        public int? SubformId { get; set; }
    }
}
