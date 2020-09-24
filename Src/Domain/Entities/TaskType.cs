using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities
{
    /// <summary>
    /// Тип поручения
    /// </summary>
    public class TaskType
    {
        public TaskType()
        {
            this.TaskEntities = new List<TaskEntity>();
        }

        /// <summary>
        /// Id типа поручения
        /// </summary>
        public Guid TaskTypeId { get; set; }

        /// <summary>
        /// Название типа поручения
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Поручение
        /// </summary>
        public virtual ICollection<TaskEntity> TaskEntities { get; set; }


    }
}
