using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    public class WorkplaceUserMap : IEntityTypeConfiguration<WorkplaceUser>
    {
        public void Configure(EntityTypeBuilder<WorkplaceUser> builder)
        {
            builder.HasKey(t => t.WorkplaceUserId);

            builder.ToTable("Workplace_User");

            builder.Property(t => t.WorkplaceId).HasColumnName("WorkplaceId");
            builder.Property(t => t.UserId).HasColumnName("UserId");
            builder.Property(t => t.IsMainWorkplace).HasColumnName("IsMainWorkplace");

            builder.HasRequired(t => t.Workplace)
                .WithMany(t => t.WorkplaceUsers)
                .HasForeignKey(t => t.WorkplaceId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasRequired(t => t.User)
                .WithMany(t => t.WorkplacesUsers)
                .HasForeignKey(t => t.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }

}
