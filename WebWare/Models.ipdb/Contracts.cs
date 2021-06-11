using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class Contracts
    {
        public int Id { get; set; }
        public string ContractFile { get; set; }
        public string ContractId { get; set; }
        public string ContractorName { get; set; }
        public string ContractorId { get; set; }
        public string ContractDate { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string ContractPrice { get; set; }
        public string ContractTitle { get; set; }
    }
}
