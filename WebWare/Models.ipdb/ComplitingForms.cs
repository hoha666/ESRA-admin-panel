using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class ComplitingForms
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string GroupId { get; set; }
        public string DeadLine { get; set; }
        public string FormId { get; set; }
        public bool IsSendMail { get; set; }
        public bool IsSendSms { get; set; }
        public string Description { get; set; }
        public string ShowFormId { get; set; }
        public bool ShowCoreForm { get; set; }
        public string CoreFormName { get; set; }
        public bool? ComplementaryOfForm { get; set; }
        public bool? IsSelectedCoreTable { get; set; }
        public string CoreTableName { get; set; }
        public string CoreTableField { get; set; }
        public string ConditionForCoreTable { get; set; }
        public string ValueForCoreTable { get; set; }
        public bool? IsResultState { get; set; }
        public string NodeDetailResult { get; set; }
        public string ComplementaryOfNodeDetailResult { get; set; }
        public bool IsEditableForm { get; set; }
        public string EditForm { get; set; }
        public string ComplitingFormPriority { get; set; }
        public string MandatoryForms { get; set; }
        public bool EditAllRequrds { get; set; }

        public NodeDetails IdNavigation { get; set; }
    }
}
