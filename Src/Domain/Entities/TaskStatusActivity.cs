using System;
using System.Collections.Generic;


namespace MMK_IS.Atach.Domain.Entities
{
    /// <summary>
    /// действие статуса поручения
    /// </summary>
    public class TaskStatusActivity
    {
        public Guid TaskStatusActivityId { get; set; }
        public Guid ActivityId { get; set; }
        public Guid TaskStatusId { get; set; }

        public virtual TaskStatus TaskStatus { get; set; }
        public virtual Activity Activity { get; set; }
    }
}
