using System;

namespace MMK_IS.Atach.Domain.Entities
{
    public class DocumentTypeRole
    {
        public Guid DocumentTypeRoleId { get; set; }
        public Guid DocumentTypeId { get; set; }
        public string ApplicationRoleId { get; set; }
        public Guid ApplicationRoleReadPermissionId { get; set; }
        public Guid ApplicationRoleEditPermissionId { get; set; }
        public bool IsCreateDocument { get; set; }


        public virtual ApplicationRole ApplicationRole { get; set; }
        public virtual DocumentType DocumentType { get; set; }
        public virtual ApplicationRoleEditPermission ApplicationRoleEditPermission { get; set; }
        public virtual ApplicationRoleReadPermission ApplicationRoleReadPermission { get; set; }
    }
}
