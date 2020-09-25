using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
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
