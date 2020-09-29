using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities.Dictionary;

namespace MMK_IS.Atach.Persistence.Configurations.Dictionary
{
    public class GroupCFOUsersConfiguration : IEntityTypeConfiguration<DictionaryGroupCFOUsers>
    {
        public void Configure(EntityTypeBuilder<DictionaryGroupCFOUsers> builder)
        {
            builder.HasKey(t => t.GroupCFOUserId);

            builder.ToTable("Dictionary_GroupCFOUsersMap");

            builder.Property(t => t.UserId).HasColumnName("UserId");
            builder.Property(t => t.Name).HasColumnName("Name");
            builder.Property(t => t.GroupCFOUserId).HasColumnName("GroupCFOUserId");
            builder.Property(t => t.GroupCFOId).HasColumnName("GroupCFOId");

            builder.Property(t => t.User).IsRequired();
            builder.HasOne(t => t.User)
                .WithMany(t => t.DictionaryGroupCFOUsers)
                .HasForeignKey(t => t.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(t => t.GroupCFO).IsRequired();
            builder.HasOne(t => t.GroupCFO)
                .WithMany(t => t.DictionaryGroupCFOUsers)
                .HasForeignKey(t => t.GroupCFOId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
