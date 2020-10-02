using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class FieldPropertyConfiguration : IEntityTypeConfiguration<FieldProperty>
    {
        public void Configure(EntityTypeBuilder<FieldProperty> builder)
        {
            builder.HasKey(t => t.FieldPropertyId);

            builder.ToTable("Field_Property");

            builder.Property(t => t.FieldId).HasColumnName("FieldId");
            builder.Property(t => t.Key).HasColumnName("Key");
            builder.Property(t => t.Value).HasColumnName("Value");

            builder.HasOne(t => t.Field).WithOne().IsRequired();
            builder.HasOne(t => t.Field)
                .WithMany(t => t.FieldProperties)
                .HasForeignKey(t => t.FieldId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
