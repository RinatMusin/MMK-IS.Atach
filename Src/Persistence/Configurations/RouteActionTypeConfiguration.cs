using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class RouteActionTypeMap : IEntityTypeConfiguration<RouteActionType>
    {
        public void Configure(EntityTypeBuilder<RouteActionType> builder)
        {
            builder.HasKey(t => t.RouteActionTypeId);

            builder.ToTable("Route_Action_Type");

            builder.Property(t => t.Name).HasColumnName("Name").HasColumnType("varchar");
        }

    }
}
