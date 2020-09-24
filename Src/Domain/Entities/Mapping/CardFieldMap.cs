using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    public class CardFieldMap : IEntityTypeConfiguration<CardField>
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
            builder.HasRequired(t => t.Card)
                .WithMany(t => t.CardFields)
                .HasForeignKey(d => d.CardId)
                .WillCascadeOnDelete(true);



            builder.HasRequired(t => t.Field)
                .WithMany(t => t.CardFields)
                .HasForeignKey(d => d.FieldId)
                .WillCascadeOnDelete(false);

            builder.HasOptional(t => t.FieldGroup)
                .WithMany(t => t.CardFields)
                .HasForeignKey(t => t.FieldGroupId)
                .WillCascadeOnDelete(false);

        }
    }
}
