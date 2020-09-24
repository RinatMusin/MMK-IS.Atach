using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    public class RouteActionFieldTypeMap : IEntityTypeConfiguration<RouteActionFieldType>
    {
        public void Configure(EntityTypeBuilder<RouteActionFieldType> builder)
        {
            builder.HasKey(t => t.RouteActionFieldTypeId);

            builder.ToTable("Route_Action_Field_Type");

            builder.Property(t => t.Name).HasColumnName("Name");

        }
    }
}