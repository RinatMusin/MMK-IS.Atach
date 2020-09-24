using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    public class WorkplacePropertyMap : IEntityTypeConfiguration<WorkplaceProperty>
    {
        public void Configure(EntityTypeBuilder<WorkplaceProperty> builder)
        {
            builder.HasKey(t => t.WorkplacePropertyId);

            builder.ToTable("Workplace_Property");

            builder.Property(t => t.DictionaryPropertyId).HasColumnName("DictionaryPropertyId");

            builder.Property(t => t.WorkplaceId).HasColumnName("WorkplaceId");

            builder.HasRequired(t => t.DictionaryProperty)
                .WithMany(t => t.WorkplaceProperties)
                .HasForeignKey(t => t.DictionaryPropertyId);


            builder.HasRequired(t => t.Workplace)
                .WithMany(t => t.WorkplaceProperties)
                .HasForeignKey(t => t.WorkplaceId);
        }
    }
}
