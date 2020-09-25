using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities.Dictionary;

namespace MMK_IS.Atach.Persistence.Configurations.Dictionary
{
    public class SubjectMap : IEntityTypeConfiguration<DictionarySubject>
    {
        public void Configure(EntityTypeBuilder<DictionarySubject> builder)
        {
            builder.HasKey(t => t.SubjectId);

            builder.ToTable("Dictionary_Subject");

            builder.Property(t => t.Name).HasColumnName("SubjectName");
            builder.Property(t => t.SAPCode).HasColumnName("SAPCode");
        }

    }
}
