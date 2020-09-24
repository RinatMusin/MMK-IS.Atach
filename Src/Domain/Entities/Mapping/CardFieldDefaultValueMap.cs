using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    public class CardFieldDefaultValueMap : IEntityTypeConfiguration<CardFieldDefaultValue>
    {
        public void Configure(EntityTypeBuilder<CardFieldDefaultValue> builder)
        {
            builder.HasKey(t => t.CardFieldDefaultValueId);

            builder.ToTable("Card_Field_DefaultValue");

            builder.Property(t => t.CardFieldId).HasColumnName("CardFieldId");
            builder.Property(t => t.Value).HasColumnName("Value");

            builder.HasRequired(t => t.CardField)
                .WithMany(t => t.CardFieldDefaultValues)
                .HasForeignKey(t => t.CardFieldId);

        }
    }
}
