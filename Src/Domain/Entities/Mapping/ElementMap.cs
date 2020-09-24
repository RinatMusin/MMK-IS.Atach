using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    public class ElementMap : IEntityTypeConfiguration<Element>
    {
        public void Configure(EntityTypeBuilder<Element> builder)
        {
            builder.ToTable("Element");

            builder.HasKey(t => t.ElementId);
            
            builder.Property(t => t.SystemName).HasColumnName("SystemName").HasColumnType("varchar");
            builder.Property(t => t.Type).HasColumnName("Type").HasColumnType("varchar");
        }
    }
}
