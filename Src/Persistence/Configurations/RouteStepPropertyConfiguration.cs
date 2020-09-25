using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class RouteStepPropertyMap : IEntityTypeConfiguration<RouteStepProperty>
    {
        public void Configure(EntityTypeBuilder<RouteStepProperty> builder)
        {
            builder.HasKey(t => t.RouteStepPropertyId);

            builder.ToTable("RouteStepProperty");

            builder.Property(t => t.RouteStepPropertyId).HasColumnName("RouteStepPropertyId");
            builder.Property(t => t.PropertyId).HasColumnName("PropertyId");
            builder.Property(t => t.RouteStepId).HasColumnName("RouteStepId");
            builder.Property(t => t.Value).HasColumnName("Value");

            builder.HasRequired(t => t.DictionaryProperty)
                .WithMany(t => t.RouteStepProperties)
                .HasForeignKey(t => t.PropertyId)
                .WillCascadeOnDelete(true);

            builder.HasRequired(t => t.RouteStep)
                .WithMany(t => t.RouteStepProperties)
                .HasForeignKey(t => t.RouteStepId)
                .WillCascadeOnDelete(true);
        }
    }
}
