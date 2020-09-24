using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities
{
    public class ApplicationRole : IdentityRole
    {
        public bool IsAdminPanel { get; set; }
    	/// <summary>
        /// роль приложения
        /// </summary>
        public virtual ICollection<ApplicationRoleActivity> ApplicationRoleActivities { get; set; }
        /// <summary>
        /// Сопоставление роли с типами документа 
        /// </summary>
        public virtual ICollection<DocumentTypeRole> DocumentTypeRoles { get; set; }
    }
}
