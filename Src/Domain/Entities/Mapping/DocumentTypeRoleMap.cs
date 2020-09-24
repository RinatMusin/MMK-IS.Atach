using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    public class DocumentTypeRoleMap : IEntityTypeConfiguration<DocumentTypeRole>
    {
        public void Configure(EntityTypeBuilder<DocumentTypeRole> builder)
        {
            builder.HasKey(t => t.DocumentTypeRoleId);

            builder.ToTable("DocumentType_Role");

            builder.Property(t => t.ApplicationRoleId).HasColumnName("ApplicationRoleId");
            builder.Property(t => t.DocumentTypeId).HasColumnName("DocumentTypeId");
            builder.Property(t => t.ApplicationRoleEditPermissionId).HasColumnName("ApplicationRoleEditPermissionId");
            builder.Property(t => t.ApplicationRoleReadPermissionId).HasColumnName("ApplicationRoleReadPermissionId");
            builder.Property(t => t.IsCreateDocument).HasColumnName("IsCreateDocument");

            builder.HasRequired(t => t.ApplicationRole)
                .WithMany(t => t.DocumentTypeRoles)
                .HasForeignKey(t => t.ApplicationRoleId);

            builder.HasRequired(t => t.DocumentType)
             .WithMany(t => t.DocumentTypeRoles)
             .HasForeignKey(t => t.DocumentTypeId);

            builder.HasRequired(t => t.ApplicationRoleEditPermission)
              .WithMany(t => t.DocumentTypeRoles)
              .HasForeignKey(t => t.ApplicationRoleEditPermissionId);

            builder.HasRequired(t => t.ApplicationRoleReadPermission)
              .WithMany(t => t.DocumentTypeRoles)
              .HasForeignKey(t => t.ApplicationRoleReadPermissionId);

        }

    }
}
