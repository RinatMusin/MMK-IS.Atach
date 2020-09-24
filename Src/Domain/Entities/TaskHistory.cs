using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities
{
    public class TaskHistory
    {
        public Guid TaskHistoryId { get; set; }
        public Guid TaskId { get; set; }
        public Guid TaskActionId { get; set; }
        public Guid? CreatedUserId { get; set; }
        public Guid? CanceledUserId { get; set; }
        public string Feedback { get; set; }
        public DateTime? NewExecutionDate { get; set; }
        public DateTime CreationDate { get; set; }

        public virtual TaskEntity Task { get; set; }
        public virtual TaskAction TaskAction { get; set; }
        public virtual ClientProfile CreatedUser { get; set; }
        public virtual ClientProfile CanceledUser { get; set; }

    }
}
