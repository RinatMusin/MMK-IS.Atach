using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    public class ApplicationRoleEditPermissionMap : IEntityTypeConfiguration<ApplicationRoleEditPermission>
    {
        public void Configure(EntityTypeBuilder<ApplicationRoleEditPermission> builder)
        {
            builder.HasKey(t => t.ApplicationRoleEditPermissionId);
            builder.ToTable("Application_Role_Edit_Permission");
            builder.Property(t => t.Name).HasColumnName("Name");

        }
    }
}
