using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TblPhysicalPublishLicenseStates
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public TblPhysicalPublishLicenseStates IdNavigation { get; set; }
        public TblPhysicalPublishLicenseStates InverseIdNavigation { get; set; }
    }
}
