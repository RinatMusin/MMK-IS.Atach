using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities.Dictionary;

namespace MMK_IS.Atach.Persistence.Configurations.Dictionary
{
    public class GroupParticipantConfiguration : IEntityTypeConfiguration<DictionaryGroupParticipant>
    {
        public void Configure(EntityTypeBuilder<DictionaryGroupParticipant> builder)
        {
            builder.HasKey(t => t.GroupParticipantId);

            builder.ToTable("Dictionary_GroupParticipant");

            builder.Property(t => t.Name).HasColumnName("Name");
            builder.Property(t => t.Duration).HasColumnName("Duration");
        }
    }
}
