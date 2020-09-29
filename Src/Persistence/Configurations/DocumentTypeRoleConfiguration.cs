using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
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

            builder.Property(t => t.ApplicationRole).IsRequired();
            builder.HasOne(t => t.ApplicationRole)
                .WithMany(t => t.DocumentTypeRoles)
                .HasForeignKey(t => t.ApplicationRoleId);

            builder.Property(t => t.DocumentType).IsRequired();
            builder.HasOne(t => t.DocumentType)
             .WithMany(t => t.DocumentTypeRoles)
             .HasForeignKey(t => t.DocumentTypeId);

            builder.Property(t => t.ApplicationRoleEditPermission).IsRequired();
            builder.HasOne(t => t.ApplicationRoleEditPermission)
              .WithMany(t => t.DocumentTypeRoles)
              .HasForeignKey(t => t.ApplicationRoleEditPermissionId);

            builder.Property(t => t.ApplicationRoleReadPermission).IsRequired();
            builder.HasOne(t => t.ApplicationRoleReadPermission)
              .WithMany(t => t.DocumentTypeRoles)
              .HasForeignKey(t => t.ApplicationRoleReadPermissionId);

        }

    }
}
