using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class AnalizorMgntConfirmation
    {
        public AnalizorMgntConfirmation()
        {
            AnalizorMgntSelection = new HashSet<AnalizorMgntSelection>();
        }

        public int Id { get; set; }
        public string CreatorAnalizorMgntConfirmation { get; set; }
        public string IpAnalizorMgntConfirmation { get; set; }
        public bool? RegistrationStatusAnalizorMgntConfirmation { get; set; }
        public string RegistrationDateAnalizorMgntConfirmation { get; set; }
        public string RegistrationTimeAnalizorMgntConfirmation { get; set; }
        public string AuditStatusAnalizorMgntConfirmation { get; set; }
        public string InstanceIdAnalizorMgntConfirmation { get; set; }
        public int? InstanceSridAnalizorMgntConfirmation { get; set; }

        public ICollection<AnalizorMgntSelection> AnalizorMgntSelection { get; set; }
    }
}
