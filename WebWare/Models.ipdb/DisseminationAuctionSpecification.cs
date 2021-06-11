using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class DisseminationAuctionSpecification
    {
        public int Id { get; set; }
        public string PdateStartDateVoting { get; set; }
        public DateTime? PdateStartDateVotingGregorian { get; set; }
        public string PdateEndDateVoting { get; set; }
        public DateTime? PdateEndDateVotingGregorian { get; set; }
        public string PdateDateMeeting { get; set; }
        public DateTime? PdateDateMeetingGregorian { get; set; }
        public string CreatorDisseminationAuctionSpecification { get; set; }
        public string IpDisseminationAuctionSpecification { get; set; }
        public bool? RegistrationStatusDisseminationAuctionSpecification { get; set; }
        public string RegistrationDateDisseminationAuctionSpecification { get; set; }
        public string RegistrationTimeDisseminationAuctionSpecification { get; set; }
        public string AuditStatusDisseminationAuctionSpecification { get; set; }
        public string InstanceIdDisseminationAuctionSpecification { get; set; }
        public int? InstanceSridDisseminationAuctionSpecification { get; set; }
        public string TxtCaption { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
