using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities.Dictionary;

namespace MMK_IS.Atach.Domain.Entities.Mapping.Dictionary
{
    public class SendingForRevisionMap : IEntityTypeConfiguration<DictionarySendingForRevision>
    {
        public void Configure(EntityTypeBuilder<DictionarySendingForRevision> builder)
        {
            builder.HasKey(t => t.SendingForRevisionId);

            builder.ToTable("Dictionary_SendingForRevision");

            builder.Property(t => t.Reason).HasColumnName("Reason");
            builder.Property(t => t.TypeOfAction).HasColumnName("TypeOfAction");
        }

    }
}
