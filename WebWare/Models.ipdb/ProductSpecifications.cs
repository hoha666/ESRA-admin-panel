using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class ProductSpecifications
    {
        public int Id { get; set; }
        public string TxtProductName { get; set; }
        public int? NumNumberGoods { get; set; }
        public string CreatorProductSpecifications { get; set; }
        public string IpProductSpecifications { get; set; }
        public bool? RegistrationStatusProductSpecifications { get; set; }
        public string RegistrationDateProductSpecifications { get; set; }
        public string RegistrationTimeProductSpecifications { get; set; }
        public string AuditStatusProductSpecifications { get; set; }
        public string InstanceIdProductSpecifications { get; set; }
        public int? InstanceSridProductSpecifications { get; set; }
        public int? FormId { get; set; }
        public int? ParentRecordId { get; set; }

        public ApplyingForGoodsForm1 ParentRecord { get; set; }
    }
}
