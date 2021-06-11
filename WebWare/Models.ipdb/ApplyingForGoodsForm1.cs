using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class ApplyingForGoodsForm1
    {
        public ApplyingForGoodsForm1()
        {
            ProductSpecifications = new HashSet<ProductSpecifications>();
        }

        public int Id { get; set; }
        public string CreatorApplyingForGoodsForm1 { get; set; }
        public string IpApplyingForGoodsForm1 { get; set; }
        public bool? RegistrationStatusApplyingForGoodsForm1 { get; set; }
        public string RegistrationDateApplyingForGoodsForm1 { get; set; }
        public string RegistrationTimeApplyingForGoodsForm1 { get; set; }
        public string AuditStatusApplyingForGoodsForm1 { get; set; }
        public string InstanceIdApplyingForGoodsForm1 { get; set; }
        public int? InstanceSridApplyingForGoodsForm1 { get; set; }

        public ICollection<ProductSpecifications> ProductSpecifications { get; set; }
    }
}
