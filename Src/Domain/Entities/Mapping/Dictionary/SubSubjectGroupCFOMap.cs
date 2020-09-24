﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities.Dictionary;

namespace MMK_IS.Atach.Domain.Entities.Mapping.Dictionary
{
    public class SubSubjectGroupCFOMap : IEntityTypeConfiguration<DictionarySubSubjectGroupCFO>
    {
        public void Configure(EntityTypeBuilder<DictionarySubSubjectGroupCFO> builder)
        {
            builder.HasKey(t => t.SubSubjectGroupCFOId);

            builder.ToTable("Dictionary_SubSubjectGroupCFO");

            builder.Property(t => t.SubSubjectGroupCFOId).HasColumnName("SubSubjectGroupCFOId");
            builder.Property(t => t.SubSubjectId).HasColumnName("SubSubjecId");
            builder.Property(t => t.GroupCFOId).HasColumnName("GroupCFOId");

            builder.HasRequired(t => t.SubSubject)
                .WithMany(t => t.SubSubjectGroupCFOs)
                .HasForeignKey(t => t.SubSubjectId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasRequired(t => t.GroupCFO)
                .WithMany(t => t.SubSubjectGroupCFOs)
                .HasForeignKey(t => t.GroupCFOId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
