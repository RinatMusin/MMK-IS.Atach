using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    public class RouteMap : IEntityTypeConfiguration<Route>
    {
        public void Configure(EntityTypeBuilder<Route> builder)
        {
            builder.HasKey(t => t.RouteId);

            builder.ToTable("Route");

            builder.Property(t => t.DocumentId).HasColumnName("DocumentId");
            builder.Property(t => t.Version).HasColumnName("Version");

            builder.Property(t => t.Name).HasColumnName("RouteName");

            builder.HasRequired(t => t.Document)
                .WithMany(t => t.Routes)
                .HasForeignKey(t => t.DocumentId)
                .WillCascadeOnDelete(true);
        }
    }
}
