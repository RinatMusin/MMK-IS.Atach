using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities.Dictionary;


namespace MMK_IS.Atach.Persistence.Configurations.Dictionary
{
    public class CounterPartyTypeConfiguration : IEntityTypeConfiguration<DictionaryCounterPartyType>
    {
        public void Configure(EntityTypeBuilder<DictionaryCounterPartyType> builder)
        {
            builder.HasKey(t => t.CounterPartyTypeId);

            builder.ToTable("Dictionary_CounterPartyType");

            builder.Property(t => t.Name).HasColumnName("Name");
        }
    }
}
