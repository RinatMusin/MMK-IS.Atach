using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities.Dictionary;

namespace MMK_IS.Atach.Persistence.Configurations.Dictionary
{
    public class YesNoMap : IEntityTypeConfiguration<DictionaryYesNo>
    {
        public void Configure(EntityTypeBuilder<DictionaryYesNo> builder)
        {
            builder.HasKey(t => t.YesNoId);

            builder.ToTable("Dictionary_YesNo");

            builder.Property(t => t.Name).HasColumnName("Name");
            builder.Property(t => t.Value).HasColumnName("Value");

        }
    }
}
