using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    public class FieldPropertyMap : IEntityTypeConfiguration<FieldProperty>
    {
        public void Configure(EntityTypeBuilder<FieldProperty> builder)
        {
            builder.HasKey(t => t.FieldPropertyId);

            builder.ToTable("Field_Property");

            builder.Property(t => t.FieldId).HasColumnName("FieldId");
            builder.Property(t => t.Key).HasColumnName("Key");
            builder.Property(t => t.Value).HasColumnName("Value");

            builder.HasRequired(t => t.Field)
                .WithMany(t => t.FieldProperties)
                .HasForeignKey(t => t.FieldId)
                .WillCascadeOnDelete(false);
        }
    }
}
