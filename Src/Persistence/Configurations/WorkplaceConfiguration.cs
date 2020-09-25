using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class WorkplaceMap : IEntityTypeConfiguration<Workplace>
    {
        public void Configure(EntityTypeBuilder<Workplace> builder)
        {
            builder.HasKey(t => t.WorkplaceId);

            builder.ToTable("Workplace");

            builder.Property(t => t.OrganizationId).HasColumnName("OrganizationId");
            builder.Property(t => t.ParentWorkplaceId).HasColumnName("ParentWorkplaceId");
            builder.Property(t => t.Name).HasColumnName("Name").HasColumnType("varchar");

            builder.HasRequired(t => t.UserOrganization)
                .WithMany(t => t.Workplaces)
                .HasForeignKey(t => t.OrganizationId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.ParentWorkplace)
                .WithMany()
                .HasForeignKey(t => t.ParentWorkplaceId)
                .WillCascadeOnDelete(true);
        }
    }

}
