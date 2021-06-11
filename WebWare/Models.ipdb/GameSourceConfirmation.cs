using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class GameSourceConfirmation
    {
        public int Id { get; set; }
        public string Result { get; set; }
        public string Comment { get; set; }
        public string CreatorGameSourceConfirmation { get; set; }
        public string IpGameSourceConfirmation { get; set; }
        public bool? RegistrationStatusGameSourceConfirmation { get; set; }
        public string RegistrationDateGameSourceConfirmation { get; set; }
        public string RegistrationTimeGameSourceConfirmation { get; set; }
        public string AuditStatusGameSourceConfirmation { get; set; }
        public string InstanceIdGameSourceConfirmation { get; set; }
        public int? InstanceSridGameSourceConfirmation { get; set; }
    }
}
