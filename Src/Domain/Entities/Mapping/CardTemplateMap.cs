using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    class CardTemplateMap : IEntityTypeConfiguration<CardTemplate>
    {
        public void Configure(EntityTypeBuilder<CardTemplate> builder)
        {
            builder.HasKey(t => t.CardTemplateId);
            builder.ToTable("Card_Template");

            builder.Property(t => t.Name).HasColumnName("Name").HasColumnType("varchar");
        }

    }
}
