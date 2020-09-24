using System;
using System.Collections.Generic;


namespace MMK_IS.Atach.Domain.Entities
{
    public class TaskAction
    {
        /// <summary>
        /// действие поручения
        /// </summary>
        public TaskAction()
        {
            this.TaskHistories = new List<TaskHistory>();
        }
        public Guid TaskActionId { get; set; }
        public string Name { get; set; }
        public string RusName { get; set; }

        /// <summary>
        /// История поручений 
        /// </summary>
        public virtual ICollection<TaskHistory> TaskHistories { get; set; }
    }
}
