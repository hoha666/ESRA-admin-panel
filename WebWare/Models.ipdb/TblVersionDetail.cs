using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblVersionDetail
    {
        public int Id { get; set; }
        public int? VersionId { get; set; }
        public string GameType { get; set; }
        public string OnlineType { get; set; }
        public bool? IsCompatible { get; set; }
        public string CompatibleFile { get; set; }
        public bool? IsPerformance { get; set; }
        public string PerformanceFile { get; set; }
        public bool? IsAnyLanguage { get; set; }
        public string AnyLanguageType { get; set; }
        public string AnyLanguageTitle { get; set; }
        public bool? IsFund { get; set; }
        public string FundFile { get; set; }
        public string FundName { get; set; }
        public string Refund { get; set; }
        public string Market { get; set; }
        public string DownloadLink { get; set; }
        public string GameState { get; set; }
        public string PortoType { get; set; }
        public string FundValue { get; set; }
        public string Name { get; set; }
        public int? OrganizationId { get; set; }
    }
}
