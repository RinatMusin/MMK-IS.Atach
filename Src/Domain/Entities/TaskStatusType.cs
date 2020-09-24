using System;
using System.Collections.Generic;


namespace MMK_IS.Atach.Domain.Entities
{
    /// <summary>
    /// Тип статуса
    /// </summary>
    public class TaskStatusType
    {
        public TaskStatusType()
        {
            this.TaskStatuses = new List<TaskStatus>();
        }

        /// <summary>
        /// Id типа статуса
        /// </summary>
        public Guid TaskStatusTypeId { get; set; }

        /// <summary>
        /// Название типа статуса
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Статусы поручения
        /// </summary>
        public virtual ICollection<TaskStatus> TaskStatuses { get; set; }
    }
}
