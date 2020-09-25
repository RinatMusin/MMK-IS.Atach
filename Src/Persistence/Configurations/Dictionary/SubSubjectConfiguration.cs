﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities.Dictionary;

namespace MMK_IS.Atach.Persistence.Configurations.Dictionary
{
    public class SubSubjectMap : IEntityTypeConfiguration<DictionarySubSubject>
    {
        public void Configure(EntityTypeBuilder<DictionarySubSubject> builder)
        {
            builder.HasKey(t => t.SubSubjectId);

            builder.ToTable("Dictionary_SubSubject");

            builder.Property(t => t.SubjectId).HasColumnName("SubjectId");
            builder.Property(t => t.SubSubjectName).HasColumnName("SubSubjectName");
            builder.Property(t => t.TypeOfContractId).HasColumnName("TypeOfContractId");
            builder.Property(t => t.TypeOfDocumentContractId).HasColumnName("TypeOfDocumentContractId");
            builder.Property(t => t.ReglamentF223).HasColumnName("ReglamentF223");

            builder.HasRequired(t => t.Subject)
                .WithMany(t => t.SubSubjects)
                .HasForeignKey(t => t.SubjectId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.TypeOfContract)
              .WithMany(t => t.SubSubjects)
              .HasForeignKey(t => t.TypeOfContractId)
              .OnDelete(DeleteBehavior.Cascade);

            builder.HasRequired(t => t.TypesOfDocumentContract)
              .WithMany(t => t.SubSubjects)
              .HasForeignKey(t => t.TypeOfDocumentContractId)
              .OnDelete(DeleteBehavior.Cascade);
        }



    }
}
