using System;
using System.Collections.Generic;


namespace MMK_IS.Atach.Domain.Entities
{
    /// <summary>
    /// Группа к которой относятся пользователи
    /// </summary>
    public class Group
    {
        public Group()
        {
            this.UserGroups = new List<UserGroup>();
        }
        /// <summary>
        /// Id группы
        /// </summary>
        public Guid GroupId { get; set; }

        /// <summary>
        /// Имя группы
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Длителность шага (в днях)
        /// </summary>
        public int Duration { get; set; }

        /// <summary>
        /// Аватар пользователя
        /// </summary>
        public byte[] Avatar { get; set; }
        /// <summary>
        /// Группы пользователей
        /// </summary>
        public virtual ICollection<UserGroup> UserGroups { get; set; }

        /// <summary>
        /// Шаги
        /// </summary>
        public virtual ICollection<RouteStep> RouteSteps { get; set; }

        /// <summary>
        /// Шаги
        /// </summary>
        public virtual ICollection<RouteStepTemplate> RouteStepTemplates { get; set; }
    }
}