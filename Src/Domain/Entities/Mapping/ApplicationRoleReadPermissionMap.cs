using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    public class ApplicationRoleReadPermissionMap : IEntityTypeConfiguration<ApplicationRoleReadPermission>
    {
        public void Configure(EntityTypeBuilder<ApplicationRoleReadPermission> builder)
        {
            builder.HasKey(t => t.ApplicationRoleReadPermissionId);

            builder.ToTable("Application_Role_Read_Permission");

            builder.Property(t => t.Name).HasColumnName("Name");
        }
    }
}
