using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    public class UserOrganizationMap : IEntityTypeConfiguration<UserOrganization>
    {
        public void Configure(EntityTypeBuilder<UserOrganization> builder)
        {
            // Primary Key
            builder.HasKey(t => t.UserOrganizationId);

            // Properties
            // Table & Column Mappings
            builder.ToTable("Organization");

            builder.Property(t => t.OrganizationTypeId).HasColumnName("OrganizationTypeId");
            builder.Property(t => t.Name).HasColumnName("Name").HasColumnType("varchar");


            builder.HasRequired(t => t.UserOrganizationType)
              .WithMany(t => t.UserOrganizations)
              .HasForeignKey(t => t.OrganizationTypeId)
              .WillCascadeOnDelete(false);

            builder.HasOptional(t => t.ParentUserOrganization)
                .WithMany()
                .HasForeignKey(d => d.ParentOrganizationId)
                .WillCascadeOnDelete(false);


        }
    }
}
