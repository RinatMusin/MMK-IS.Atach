using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class DocumentTypeRoleConfiguration : IEntityTypeConfiguration<DocumentTypeRole>
    {
        public void Configure(EntityTypeBuilder<DocumentTypeRole> builder)
        {
            builder.HasKey(t => t.DocumentTypeRoleId);

            builder.ToTable("DocumentType_Role");

            builder.Property(t => t.ApplicationRoleId).HasColumnName("ApplicationRoleId").HasMaxLength(128);
            builder.Property(t => t.DocumentTypeId).HasColumnName("DocumentTypeId");
            builder.Property(t => t.ApplicationRoleEditPermissionId).HasColumnName("ApplicationRoleEditPermissionId");
            builder.Property(t => t.ApplicationRoleReadPermissionId).HasColumnName("ApplicationRoleReadPermissionId");
            builder.Property(t => t.IsCreateDocument).HasColumnName("IsCreateDocument");

            builder.Ignore(t => t.ApplicationRole);
            //builder.HasOne(t => t.ApplicationRole).WithOne().IsRequired();
            //builder.HasOne(t => t.ApplicationRole).WithMany(t => t.DocumentTypeRoles) .HasForeignKey(t => t.ApplicationRoleId);

            builder.HasOne(t => t.DocumentType).WithOne().IsRequired();
            builder.HasOne(t => t.DocumentType)
             .WithMany(t => t.DocumentTypeRoles)
             .HasForeignKey(t => t.DocumentTypeId);

            builder.HasOne(t => t.ApplicationRoleEditPermission).WithOne().IsRequired();
            builder.HasOne(t => t.ApplicationRoleEditPermission)
              .WithMany(t => t.DocumentTypeRoles)
              .HasForeignKey(t => t.ApplicationRoleEditPermissionId);

            builder.HasOne(t => t.ApplicationRoleReadPermission).WithOne().IsRequired();
            builder.HasOne(t => t.ApplicationRoleReadPermission)
              .WithMany(t => t.DocumentTypeRoles)
              .HasForeignKey(t => t.ApplicationRoleReadPermissionId);

        }

    }
}
