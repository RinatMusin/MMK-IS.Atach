using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities.Queries
{
    public class ReportOnContractDocumentsModel
    {
        public Guid DocumentId { get; set; }
        public string DocumentType { get; set; }
        public string ViewTypeOfContract { get; set; }
        public string Counterparty { get; set; }
        public string CFO { get; set; }
        public string AttachUserFIO { get; set; }
        public string ActionStartDate { get; set; }
        public string DateOfConclusion { get; set; }
    }
}
