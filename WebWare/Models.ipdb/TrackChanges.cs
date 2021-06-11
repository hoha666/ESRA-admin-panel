using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TrackChanges
    {
        public Guid Id { get; set; }
        public string EntityName { get; set; }
        public DateTime Date { get; set; }
        public string Track { get; set; }
        public string UserName { get; set; }
        public string Processes { get; set; }
        public int? FormId { get; set; }
        public int ChangeType { get; set; }
        public string Ip { get; set; }
        public string TrackJson { get; set; }
        public string ToJson { get; set; }
        public string Title { get; set; }
        public string Tags { get; set; }
    }
}
