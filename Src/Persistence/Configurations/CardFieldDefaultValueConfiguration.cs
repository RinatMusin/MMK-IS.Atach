using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class CardFieldDefaultValueMap : IEntityTypeConfiguration<CardFieldDefaultValue>
    {
        public void Configure(EntityTypeBuilder<CardFieldDefaultValue> builder)
        {
            builder.HasKey(t => t.CardFieldDefaultValueId);

            builder.ToTable("Card_Field_DefaultValue");

            builder.Property(t => t.CardFieldId).HasColumnName("CardFieldId");
            builder.Property(t => t.Value).HasColumnName("Value");

            builder.Property(t => t.CardField).IsRequired();
            builder.HasOne(t => t.CardField)
                .WithMany(t => t.CardFieldDefaultValues)
                .HasForeignKey(t => t.CardFieldId);

        }
    }
}
