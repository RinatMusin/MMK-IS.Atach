using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities.Dictionary;

namespace MMK_IS.Atach.Persistence.Configurations.Dictionary
{
    public class SubdivisionOZMMap : IEntityTypeConfiguration<DictionarySubdivisionOZM>
    {
        public void Configure(EntityTypeBuilder<DictionarySubdivisionOZM> builder)
        {
            builder.HasKey(t => t.SubdivisionOZMId);

            builder.ToTable("Dictionary_SubdivisionOZM");

            builder.Property(t => t.Name).HasColumnName("Name");
            builder.Property(t => t.Description).HasColumnName("Description");

        }
    }
}
