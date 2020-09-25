using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities.Dictionary;

namespace MMK_IS.Atach.Persistence.Configurations.Dictionary
{
    public class DictionaryCurrencyMap : IEntityTypeConfiguration<DictionaryCurrency>
    {
        public void Configure(EntityTypeBuilder<DictionaryCurrency> builder)
        {
            builder.HasKey(t => t.CurrencyId);

            builder.ToTable("Dictionary_Currency");

            builder.Property(t => t.DigitalCode).HasColumnName("DigitalCode");
            builder.Property(t => t.LetterCode).HasColumnName("LetterCode");
            builder.Property(t => t.CurrencyName).HasColumnName("CurrencyName");
        }

    }
}
