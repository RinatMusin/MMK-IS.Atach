using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities
{
    /// <summary>
    /// Организация содержащая рабочие места
    /// </summary>
    public class UserOrganization
    {
        public UserOrganization()
        {
            this.Workplaces = new List<Workplace>();
        }

        /// <summary>
        /// Id организации
        /// </summary>
        public Guid UserOrganizationId { get; set; }

        /// <summary>
        /// Тип организации
        /// </summary>
        public Guid OrganizationTypeId { get; set; }

        /// <summary>
        /// Id родительской организации
        /// </summary>
        public Guid? ParentOrganizationId { get; set; }
        /// <summary>
        /// Название организации
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Тип организации
        /// </summary>
        public virtual UserOrganizationType UserOrganizationType { get; set; }

        /// <summary>
        /// родительская организация
        /// </summary>
        public virtual UserOrganization ParentUserOrganization { get; set; }

        /// <summary>
        /// Рабочие места
        /// </summary>
        public virtual ICollection<Workplace> Workplaces { get; set; }
    }
}

