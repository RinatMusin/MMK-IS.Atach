using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class CardFieldConfiguration : IEntityTypeConfiguration<CardField>
    {
        public void Configure(EntityTypeBuilder<CardField> builder)
        {
            // Primary Key
            builder.HasKey(t => t.CardFieldId);

            // Properties
            // Table & Column Mappings
            builder.ToTable("Card_Field");

            builder.Property(t => t.FieldId).HasColumnName("FieldId");
            builder.Property(t => t.CardId).HasColumnName("CardId");
            builder.Property(t => t.FieldGroupId).HasColumnName("FieldGroupId");
            builder.Property(t => t.IsDisabled).HasColumnName("IsDisabled");
            builder.Property(t => t.IsRequired).HasColumnName("IsRequired");
            builder.Property(t => t.IsMultirow).HasColumnName("IsMultirow");
            builder.Property(t => t.IsVisible).HasColumnName("IsVisible");
            builder.Property(t => t.DataUrl).HasColumnName("DataUrl");
            builder.Property(t => t.DisplayOrder).HasColumnName("DisplayOrder");

            // Relationships
            builder.Property(t => t.Card).IsRequired();
            builder.HasOne(t => t.Card)
                .WithMany(t => t.CardFields)
                .HasForeignKey(d => d.CardId)
                .OnDelete(DeleteBehavior.Cascade);
            
            builder.Property(t => t.Field).IsRequired();
            builder.HasOne(t => t.Field)
                .WithMany(t => t.CardFields)
                .HasForeignKey(d => d.FieldId)
                .OnDelete(DeleteBehavior.Cascade);
            
            builder.HasOne(t => t.FieldGroup)
                .WithMany(t => t.CardFields)
                .HasForeignKey(t => t.FieldGroupId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
