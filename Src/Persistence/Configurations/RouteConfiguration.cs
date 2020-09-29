using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class RouteConfiguration : IEntityTypeConfiguration<Route>
    {
        public void Configure(EntityTypeBuilder<Route> builder)
        {
            builder.HasKey(t => t.RouteId);

            builder.ToTable("Route");

            builder.Property(t => t.DocumentId).HasColumnName("DocumentId");
            builder.Property(t => t.Version).HasColumnName("Version");

            builder.Property(t => t.Name).HasColumnName("RouteName");

            builder.Property(t => t.Document).IsRequired();
            builder.HasOne(t => t.Document)
                .WithMany(t => t.Routes)
                .HasForeignKey(t => t.DocumentId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
