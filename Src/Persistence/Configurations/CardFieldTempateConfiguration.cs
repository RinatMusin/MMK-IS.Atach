using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class CardFieldTempateConfiguration : IEntityTypeConfiguration<CardFieldTempate>
    {
        public void Configure(EntityTypeBuilder<CardFieldTempate> builder)
        {
            builder.HasKey(t => t.CardFieldTempateId);

            builder.ToTable("Card_Field_Template");

            builder.Property(t => t.CardFieldId).HasColumnName("CardFieldId");
            builder.Property(t => t.TemplateId).HasColumnName("TemplateId");

            builder.Property(t => t.Value).HasColumnName("Value").HasColumnType("varchar");


            builder.Property(t => t.CardField).IsRequired();
            builder.HasOne(t => t.CardField)
                .WithMany(t => t.CardFieldTempates)
                .HasForeignKey(t => t.CardFieldId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(t => t.CardTemplate).IsRequired();
            builder.HasOne(t => t.CardTemplate)
             .WithMany(t => t.CardFieldTempates)
             .HasForeignKey(t => t.TemplateId)
             .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
