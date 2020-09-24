using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities.Queries
{
    public class ReportOnDocumentSectionsModel
    {
        public Guid DocumentId { get; set; }
        public string Department { get; set; }
        public string RegNumber { get; set; }
        public string RegDate { get; set; }
        public string Signer { get; set; }
        public string Summary { get; set; }
        public string OwnerUser { get; set; }
        public string Action { get; set; }
        public string DocumentType { get; set; }
    }
}
