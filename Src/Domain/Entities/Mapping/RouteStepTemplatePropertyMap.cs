using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    public class RouteStepTemplatePropertyMap : IEntityTypeConfiguration<RouteStepTemplateProperty>
    {
        public void Configure(EntityTypeBuilder<RouteStepTemplateProperty> builder)
        {
         builder.HasKey(t => t.RouteStepTemplatePropertyId);

            builder.ToTable("RouteStepTemplateProperty");

            builder.Property(t => t.RouteStepTemplatePropertyId).HasColumnName("RouteStepTemplatePropertyId");
            builder.Property(t => t.PropertyId).HasColumnName("PropertyId");
            builder.Property(t => t.RouteStepTemplateId).HasColumnName("RouteStepTemplateId");
            builder.Property(t => t.Value).HasColumnName("Value");

            builder.HasRequired(t => t.DictionaryProperty)
                .WithMany(t => t.RouteStepTemplateProperties)
                .HasForeignKey(t => t.PropertyId)
                .WillCascadeOnDelete(true);

            builder.HasRequired(t => t.RouteStepTemplate)
                .WithMany(t => t.RouteStepTemplateProperties)
                .HasForeignKey(t => t.RouteStepTemplateId)
                .WillCascadeOnDelete(true);
        }
    }
}
