using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities
{
    /// <summary>
    /// Рабочее место сотрудника для доступа к таскам
    /// </summary>
    public class Workplace
    {
        /// <summary>
        /// Id рабочего места
        /// </summary>
        public Guid WorkplaceId { get; set; }

        /// <summary>
        /// идентификатор родительская позиция для иерархии 
        /// </summary>
        public Guid? ParentWorkplaceId { get; set; }


        /// <summary>
        /// Id организации
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Имя рабочего места
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Родительская позиция для иерархии 
        /// </summary>
        public virtual Workplace ParentWorkplace { get; set; }

        /// <summary>
        /// Пользователь 
        /// </summary>
        public virtual ICollection<WorkplaceUser> WorkplaceUsers { get; set; }

        /// <summary>
        /// Пользователь 
        /// </summary>
        public virtual UserOrganization UserOrganization { get; set; }

        /// <summary>
        /// Поручения
        /// </summary>
        public virtual ICollection<TaskEntity> TaskEntities { get; set; }

        /// <summary>
        /// Свойства
        /// </summary>
        public virtual ICollection<WorkplaceProperty> WorkplaceProperties { get; set; }
    }
}
