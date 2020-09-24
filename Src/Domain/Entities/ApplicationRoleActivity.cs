using System;

namespace MMK_IS.Atach.Domain.Entities
{
    public class ApplicationRoleActivity
    {
        /// <summary>
        /// действие роли приложения
        /// </summary>
        public Guid ApplicationRoleActivityId { get; set; }
        public Guid ActivityId { get; set; }
        public string RoleId { get; set; }

        public virtual ApplicationRole ApplicationRole { get; set; }
        public virtual Activity Activity { get; set; }
    }
}
