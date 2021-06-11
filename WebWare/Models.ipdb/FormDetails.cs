using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class FormDetails
    {
        public FormDetails()
        {
            Laws = new HashSet<Laws>();
        }

        public int Id { get; set; }
        public string FormName { get; set; }
        public string FormTitle { get; set; }
        public string TableName { get; set; }
        public string InsertStatement { get; set; }
        public string SelectStatement { get; set; }
        public string UpdateStatement { get; set; }
        public string SubmitButtonText { get; set; }
        public string SuccessMessage { get; set; }
        public bool IsProtected { get; set; }
        public string Password { get; set; }
        public string SettingShow { get; set; }
        public string FormHeader { get; set; }
        public string FormFooter { get; set; }
        public int FormGroupId { get; set; }
        public int? FormSubGroupId { get; set; }
        public string TsqlLaw { get; set; }

        public ICollection<Laws> Laws { get; set; }
    }
}
