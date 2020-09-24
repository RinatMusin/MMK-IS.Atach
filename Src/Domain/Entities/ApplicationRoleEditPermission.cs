using System;
using System.Collections.Generic;

namespace MMK_IS.Atach.Domain.Entities
{
    public class ApplicationRoleEditPermission
    {
        public Guid ApplicationRoleEditPermissionId { get; set; }
        public string Name { get; set; }

        /// <summary>
        /// Сопоставление роли с типами документа 
        /// </summary>
        public virtual ICollection<DocumentTypeRole> DocumentTypeRoles { get; set; }
    }
}
