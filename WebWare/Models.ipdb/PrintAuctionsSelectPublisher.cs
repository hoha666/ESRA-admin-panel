using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class PrintAuctionsSelectPublisher
    {
        public int Id { get; set; }
        public string PdateAuctionDatePrinting { get; set; }
        public DateTime? PdateAuctionDatePrintingGregorian { get; set; }
        public string TimeAuctionsHoursPrinting { get; set; }
        public string CreatorPrintAuctionsSelectPublisher { get; set; }
        public string IpPrintAuctionsSelectPublisher { get; set; }
        public bool? RegistrationStatusPrintAuctionsSelectPublisher { get; set; }
        public string RegistrationDatePrintAuctionsSelectPublisher { get; set; }
        public string RegistrationTimePrintAuctionsSelectPublisher { get; set; }
        public string AuditStatusPrintAuctionsSelectPublisher { get; set; }
        public string InstanceIdPrintAuctionsSelectPublisher { get; set; }
        public int? InstanceSridPrintAuctionsSelectPublisher { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }
    }
}
