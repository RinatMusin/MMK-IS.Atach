using System;
using System.Collections.Generic;


namespace MMK_IS.Atach.Domain.Entities
{
    public class KonturCloudTransaction
    {
        public Guid KonturCloudTransactionId { get; set; }
        public string TransactionId { get; set; }
        public bool IsFinished { get; set; }
        public bool InProcessing { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime? CompletionTime { get; set; }
        public Guid DocumentId { get; set; }
        public Guid TaskId { get; set; }
        public virtual Document Document { get; set; }
        public virtual TaskEntity Task { get; set; }
    }
}