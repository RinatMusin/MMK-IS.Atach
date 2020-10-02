using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities.Dictionary;

namespace MMK_IS.Atach.Persistence.Configurations.Dictionary
{
    public class SubSubjectGroupCFOConfiguration : IEntityTypeConfiguration<DictionarySubSubjectGroupCFO>
    {
        public void Configure(EntityTypeBuilder<DictionarySubSubjectGroupCFO> builder)
        {
            builder.HasKey(t => t.SubSubjectGroupCFOId);

            builder.ToTable("Dictionary_SubSubjectGroupCFO");

            builder.Property(t => t.SubSubjectGroupCFOId).HasColumnName("SubSubjectGroupCFOId");
            builder.Property(t => t.SubSubjectId).HasColumnName("SubSubjecId");
            builder.Property(t => t.GroupCFOId).HasColumnName("GroupCFOId");

            builder.HasOne(t => t.SubSubject).WithOne().IsRequired();
            builder.HasOne(t => t.SubSubject)
                .WithMany(t => t.SubSubjectGroupCFOs)
                .HasForeignKey(t => t.SubSubjectId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.GroupCFO).WithOne().IsRequired();
            builder.HasOne(t => t.GroupCFO)
                .WithMany(t => t.SubSubjectGroupCFOs)
                .HasForeignKey(t => t.GroupCFOId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
