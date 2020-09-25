using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities.Dictionary;

namespace MMK_IS.Atach.Persistence.Configurations.Dictionary
{
    public class DictionaryPropertyTypeMap : IEntityTypeConfiguration<DictionaryPropertyType>
    {
        public void Configure(EntityTypeBuilder<DictionaryPropertyType> builder)
        {
            builder.HasKey(t => t.PropertyTypeId);

            builder.ToTable("DictionaryPropertyType");

            builder.Property(t => t.PropertyTypeId).HasColumnName("PropertyTypeId");
            builder.Property(t => t.TypeName).HasColumnName("TypeName");
        }
    }
}
