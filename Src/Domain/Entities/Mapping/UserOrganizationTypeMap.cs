using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    public class OrganizationTypeMap : IEntityTypeConfiguration<UserOrganizationType>
    {
        public void Configure(EntityTypeBuilder<UserOrganizationType> builder)
        {
            builder.HasKey(t => t.UserOrganizationTypeId);

            builder.ToTable("Organization_Type");

            builder.Property(t => t.Name).HasColumnName("Name").HasColumnType("varchar");
        }
    }
}
