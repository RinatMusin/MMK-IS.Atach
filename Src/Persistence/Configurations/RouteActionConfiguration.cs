using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class RouteActionConfiguration : IEntityTypeConfiguration<RouteAction>
    {
        public void Configure(EntityTypeBuilder<RouteAction> builder)
        {
            builder.HasKey(t => t.RouteActionId);

            builder.ToTable("Route_Action");

            builder.Property(t => t.Name).HasColumnName("Name").HasColumnType("varchar");

            builder.Property(t => t.RouteActionType).IsRequired();
            builder.HasOne(t => t.RouteActionType)
                .WithMany(t => t.RouteActions)
                .HasForeignKey(t => t.RouteActionTypeId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
