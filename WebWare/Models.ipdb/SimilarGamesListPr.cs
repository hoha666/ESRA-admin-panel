using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class SimilarGamesListPr
    {
        public int Id { get; set; }
        public string CreatorSimilarGamesListPr { get; set; }
        public string IpSimilarGamesListPr { get; set; }
        public bool? RegistrationStatusSimilarGamesListPr { get; set; }
        public string RegistrationDateSimilarGamesListPr { get; set; }
        public string RegistrationTimeSimilarGamesListPr { get; set; }
        public string AuditStatusSimilarGamesListPr { get; set; }
        public string InstanceIdSimilarGamesListPr { get; set; }
        public int? InstanceSridSimilarGamesListPr { get; set; }
        public string DdlIsRepeat { get; set; }
        public string DdlCompanyRepeat { get; set; }
        public string TxtCn { get; set; }
    }
}
