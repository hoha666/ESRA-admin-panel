using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class UpstreamDocuments
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RegistrationId { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string CompanyName { get; set; }
        public string CompanyType { get; set; }
        public string Requirement { get; set; }
        public string ActivityTitle { get; set; }
        public string MainCompany { get; set; }
        public int CompanyDuration { get; set; }
        public int CompanyFund { get; set; }
        public string CompanyNationality { get; set; }
        public int MemberOfBoardId { get; set; }
        public int AppendixId { get; set; }
        public int ArchieveId { get; set; }
    }
}
