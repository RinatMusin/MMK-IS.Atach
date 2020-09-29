using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class RouteActionFieldTypeConfiguration : IEntityTypeConfiguration<RouteActionFieldType>
    {
        public void Configure(EntityTypeBuilder<RouteActionFieldType> builder)
        {
            builder.HasKey(t => t.RouteActionFieldTypeId);

            builder.ToTable("Route_Action_Field_Type");

            builder.Property(t => t.Name).HasColumnName("Name");

        }
    }
}