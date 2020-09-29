using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities.Dictionary;

namespace MMK_IS.Atach.Persistence.Configurations.Dictionary
{
    public class TypesOfDocumentContractConfiguration : IEntityTypeConfiguration<DictionaryTypesOfDocumentContract>
    {
        public void Configure(EntityTypeBuilder<DictionaryTypesOfDocumentContract> builder)
        {
            builder.HasKey(t => t.TypeOfDocumentContractId);

            builder.ToTable("Dictionary_TypesOfDocumentContract");

            builder.Property(t => t.TypeOfDocumentContract).HasColumnName("TypeOfDocumentContract");
        }

    }
}
