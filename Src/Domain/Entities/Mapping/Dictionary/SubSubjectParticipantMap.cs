using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities.Dictionary;

namespace MMK_IS.Atach.Domain.Entities.Mapping.Dictionary
{
    public class SubSubjectParticipantMap : IEntityTypeConfiguration<DictionarySubSubjectParticipant>
    {
        public void Configure(EntityTypeBuilder<DictionarySubSubjectParticipant> builder)
        {
            builder.HasKey(t => t.SubSubjectParticipantId);

            builder.ToTable("Dictionary_SubSubjectParticipant");

            builder.Property(t => t.SubSubjectId).HasColumnName("SubSubjectId");
            builder.Property(t => t.SubSubjectName).HasColumnName("SubSubjectName");
            builder.Property(t => t.GroupParticipantId).HasColumnName("GroupParticipantId");
            builder.Property(t => t.GroupParticipantName).HasColumnName("GroupParticipantName");


            builder.HasRequired(t => t.SubSubject)
                .WithMany(t => t.SubSubjectParticipants)
                .HasForeignKey(t => t.SubSubjectId)
                .WillCascadeOnDelete(false);


            builder.HasRequired(t => t.GroupParticipant)
                .WithMany(t => t.SubSubjectParticipants)
                .HasForeignKey(t => t.GroupParticipantId)
                .WillCascadeOnDelete(false);

        }

    }
}
