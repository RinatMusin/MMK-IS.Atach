using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities
{
    /// <summary>
    /// Группа для поручений
    /// </summary>
    public class GroupAssign
    {
        public GroupAssign()
        {
            this.UserGroupsAssign = new List<UserGroupAssign>();
        }

        /// <summary>
        /// Id группы
        /// </summary>
        public Guid GroupAssignId { get; set; }

        /// <summary>
        /// Имя группы
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Id создателя группы
        /// </summary>
        public Guid ClientProfileId { get; set; }

        /// <summary>
        /// Порядок сортировки
        /// </summary>
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Группы пользователей
        /// </summary>
        public virtual ICollection<UserGroupAssign> UserGroupsAssign { get; set; }

        /// <summary>
        /// Создатель группы
        /// </summary>
        public virtual ClientProfile ClientProfile { get; set; }
    }
}
