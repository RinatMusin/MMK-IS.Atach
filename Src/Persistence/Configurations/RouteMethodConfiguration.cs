using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Domain.Entities
{
    public class RouteMethodMap : IEntityTypeConfiguration<RouteMethod>
    {
        public void Configure(EntityTypeBuilder<RouteMethod> builder)
        {
            builder.HasKey(t => t.RouteMethodId);

            builder.ToTable("Route_Method");

            builder.Property(t => t.Name).HasColumnName("Name");
        }
    }
}
