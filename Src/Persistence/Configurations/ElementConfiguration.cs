using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class ElementConfiguration : IEntityTypeConfiguration<Element>
    {
        public void Configure(EntityTypeBuilder<Element> builder)
        {
            builder.ToTable("Element");

            builder.HasKey(t => t.ElementId);
            
            builder.Property(t => t.SystemName).HasColumnName("SystemName").HasMaxLength(8000);
            builder.Property(t => t.Type).HasColumnName("Type").HasMaxLength(8000);
        }
    }
}
