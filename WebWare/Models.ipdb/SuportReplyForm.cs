using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class SuportReplyForm
    {
        public SuportReplyForm()
        {
            RelationPeopleSuportReplyForm = new HashSet<RelationPeopleSuportReplyForm>();
        }

        public int Id { get; set; }
        public string TxtPasokh { get; set; }
        public string FileUpl { get; set; }
        public string CreatorSuportReplyForm { get; set; }
        public string IpSuportReplyForm { get; set; }
        public bool? RegistrationStatusSuportReplyForm { get; set; }
        public string RegistrationDateSuportReplyForm { get; set; }
        public string RegistrationTimeSuportReplyForm { get; set; }
        public string AuditStatusSuportReplyForm { get; set; }
        public string InstanceIdSuportReplyForm { get; set; }
        public int? InstanceSridSuportReplyForm { get; set; }

        public ICollection<RelationPeopleSuportReplyForm> RelationPeopleSuportReplyForm { get; set; }
    }
}
