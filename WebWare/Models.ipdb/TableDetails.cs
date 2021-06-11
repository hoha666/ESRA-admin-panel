using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class TableDetails
    {
        public int Id { get; set; }
        public string TableName { get; set; }
        public string TableField { get; set; }
        public string DisplayType { get; set; }
        public string FirstTableFieldSetting { get; set; }
        public string Scale { get; set; }
        public string TableNameSetting { get; set; }
        public string TableFieldSetting { get; set; }
        public string Parameter { get; set; }
        public bool IsSelectable { get; set; }
        public bool IsDeletable { get; set; }
        public string Tsql { get; set; }
        public bool IsSingleSelection { get; set; }

        public FormFields IdNavigation { get; set; }
    }
}
