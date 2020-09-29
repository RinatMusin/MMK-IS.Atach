using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class WorkplacePropertyMap : IEntityTypeConfiguration<WorkplaceProperty>
    {
        public void Configure(EntityTypeBuilder<WorkplaceProperty> builder)
        {
            builder.HasKey(t => t.WorkplacePropertyId);

            builder.ToTable("Workplace_Property");

            builder.Property(t => t.DictionaryPropertyId).HasColumnName("DictionaryPropertyId");

            builder.Property(t => t.WorkplaceId).HasColumnName("WorkplaceId");
                        
            builder.Property(t => t.DictionaryProperty).IsRequired();
            builder.HasOne(t => t.DictionaryProperty).WithMany(t => t.WorkplaceProperties).HasForeignKey(t => t.DictionaryPropertyId);
            
            builder.Property(t => t.Workplace).IsRequired();
            builder.HasOne(t => t.Workplace).WithMany(t => t.WorkplaceProperties).HasForeignKey(t => t.WorkplaceId);
        }
    }
}
