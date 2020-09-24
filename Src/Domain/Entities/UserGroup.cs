using System;
using System.Collections.Generic;


namespace MMK_IS.Atach.Domain.Entities
{
    /// <summary>
    /// Таблица для связи многое ко многим м\у пользоватлями к группами
    /// </summary>
    public class UserGroup
    {
        public Guid UserGroupId { get; set; }

        /// <summary>
        /// Id пользователя
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// Id группы
        /// </summary>
        public Guid GroupId { get; set; }

        /// <summary>
        /// Пользователь 
        /// </summary>
        public virtual ClientProfile User { get; set; }

        /// <summary>
        /// Группа 
        /// </summary>
        public virtual Group Group { get; set; }
    }
}
