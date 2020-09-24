using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities
{
    /// <summary>
    /// Тип организации пользователя
    /// </summary>
    public class UserOrganizationType
    {
        public UserOrganizationType()
        {
            this.UserOrganizations = new List<UserOrganization>();
        }

        /// <summary>
        /// Id типа организации 
        /// </summary>
        public Guid UserOrganizationTypeId { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }

        public virtual ICollection<UserOrganization> UserOrganizations { get; set; }
    }
}
