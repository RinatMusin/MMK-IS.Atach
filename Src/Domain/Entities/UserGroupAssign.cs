using System;
using System.Collections.Generic;


namespace MMK_IS.Atach.Domain.Entities
{
    /// <summary>
    /// Пользователи группы для поручений
    /// </summary>
    public class UserGroupAssign
    {
        /// <summary>
        /// Id пользователя
        /// </summary>
        public Guid UserGroupAssignId { get; set; }

        /// <summary>
        /// Id пользователя
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// Id группы
        /// </summary>
        public Guid GroupAssignId { get; set; }

        /// <summary>
        /// Пользователь 
        /// </summary>
        public virtual ClientProfile User { get; set; }

        /// <summary>
        /// Группа 
        /// </summary>
        public virtual GroupAssign GroupAssign { get; set; }
    }
}
