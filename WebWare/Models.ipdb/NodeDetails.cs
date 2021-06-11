using System;
using System.Collections.Generic;

namespace WebWare.Models_ipdb
{
    public partial class NodeDetails
    {
        public int Id { get; set; }
        public string ViewName { get; set; }
        public int WorkFlowDetailId { get; set; }
        public string Type { get; set; }
        public string PrevNode { get; set; }
        public string NextNode { get; set; }
        public int Key { get; set; }
        public string LinkText { get; set; }
        public bool Status { get; set; }

        public WorkFlowDetails WorkFlowDetail { get; set; }
        public CheckingForms CheckingForms { get; set; }
        public ComplitingForms ComplitingForms { get; set; }
        public ReadFromAnotherDbs ReadFromAnotherDbs { get; set; }
        public SendingMails SendingMails { get; set; }
        public SendingSms SendingSms { get; set; }
        public StoreInAnotherDbs StoreInAnotherDbs { get; set; }
        public SubWorkFlowExecutions SubWorkFlowExecutions { get; set; }
        public WebServices WebServices { get; set; }
        public WfwCalculations WfwCalculations { get; set; }
        public WfwDecisions WfwDecisions { get; set; }
        public WorkFlowStartEnds WorkFlowStartEnds { get; set; }
    }
}
