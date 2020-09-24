using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    public class RouteActionMap : IEntityTypeConfiguration<RouteAction>
    {
        public void Configure(EntityTypeBuilder<RouteAction> builder)
        {
            builder.HasKey(t => t.RouteActionId);

            builder.ToTable("Route_Action");

            builder.Property(t => t.Name).HasColumnName("Name").HasColumnType("varchar");

            builder.HasRequired(t => t.RouteActionType)
                .WithMany(t => t.RouteActions)
                .HasForeignKey(t => t.RouteActionTypeId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
