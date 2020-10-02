using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class RouteStepTemplatePropertyConfiguration : IEntityTypeConfiguration<RouteStepTemplateProperty>
    {
        public void Configure(EntityTypeBuilder<RouteStepTemplateProperty> builder)
        {
            builder.HasKey(t => t.RouteStepTemplatePropertyId);

            builder.ToTable("RouteStepTemplateProperty");

            builder.Property(t => t.RouteStepTemplatePropertyId).HasColumnName("RouteStepTemplatePropertyId");
            builder.Property(t => t.PropertyId).HasColumnName("PropertyId");
            builder.Property(t => t.RouteStepTemplateId).HasColumnName("RouteStepTemplateId");
            builder.Property(t => t.Value).HasColumnName("Value");

            builder.HasOne(t => t.DictionaryProperty).WithOne().IsRequired();
            builder.HasOne(t => t.DictionaryProperty)
                .WithMany(t => t.RouteStepTemplateProperties)
                .HasForeignKey(t => t.PropertyId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.RouteStepTemplate).WithOne().IsRequired();
            builder.HasOne(t => t.RouteStepTemplate)
                .WithMany(t => t.RouteStepTemplateProperties)
                .HasForeignKey(t => t.RouteStepTemplateId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
