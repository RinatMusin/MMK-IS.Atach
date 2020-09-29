﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities.Dictionary;

namespace MMK_IS.Atach.Persistence.Configurations.Dictionary
{
    public class SubSubjectParticipantConfiguration : IEntityTypeConfiguration<DictionarySubSubjectParticipant>
    {
        public void Configure(EntityTypeBuilder<DictionarySubSubjectParticipant> builder)
        {
            builder.HasKey(t => t.SubSubjectParticipantId);

            builder.ToTable("Dictionary_SubSubjectParticipant");

            builder.Property(t => t.SubSubjectId).HasColumnName("SubSubjectId");
            builder.Property(t => t.SubSubjectName).HasColumnName("SubSubjectName");
            builder.Property(t => t.GroupParticipantId).HasColumnName("GroupParticipantId");
            builder.Property(t => t.GroupParticipantName).HasColumnName("GroupParticipantName");


            builder.Property(t => t.SubSubject).IsRequired();
            builder.HasOne(t => t.SubSubject)
                .WithMany(t => t.SubSubjectParticipants)
                .HasForeignKey(t => t.SubSubjectId)
                .OnDelete(DeleteBehavior.Cascade);


            builder.Property(t => t.GroupParticipant).IsRequired();
            builder.HasOne(t => t.GroupParticipant)
                .WithMany(t => t.SubSubjectParticipants)
                .HasForeignKey(t => t.GroupParticipantId)
                .OnDelete(DeleteBehavior.Cascade);

        }

    }
}
