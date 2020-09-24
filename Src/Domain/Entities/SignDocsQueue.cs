using System;
using System.Collections.Generic;


namespace MMK_IS.Atach.Domain.Entities
{
    public class SignDocsQueue
    {
        public Guid MemberId { get; set; }
        public Guid DocumentId { get; set; }
        public string Token { get; set; }
        public string TransactionId { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string PinCode { get; set; }
        public string DocsPath { get; set; }
        public string DocName { get; set; }
        public string Resume { get; set; }
        public bool IsActive { get; set; }
        public bool IsConfirmed { get; set; }
        public bool IsFinished { get; set; }
        public DateTime LastRequest { get; set; }
        public String CertUserName { get; set; }
        public String CertSerialNumber { get; set; }
        public String CertDateFrom { get; set; }
        public String CertDateTo { get; set; }
        public Guid? UniqueTransactionId { get; set; }
    }
}
