using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities.Dictionary;

namespace MMK_IS.Atach.Persistence.Configurations.Dictionary
{
    public class TypesOfContractConfiguration : IEntityTypeConfiguration<DictionaryTypesOfContract>
    {
        public void Configure(EntityTypeBuilder<DictionaryTypesOfContract> builder)
        {
            builder.HasKey(t => t.TypeOfContractId);

            builder.ToTable("Dictionary_TypesOfContract");

            builder.Property(t => t.TypeOfContract).HasColumnName("TypeOfContract");
        }

    }
}
