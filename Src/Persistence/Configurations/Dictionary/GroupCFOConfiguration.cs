using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities.Dictionary;

namespace MMK_IS.Atach.Persistence.Configurations.Dictionary
{
    public class GroupCFOMap : IEntityTypeConfiguration<DictionaryGroupCFO>
    {
        public void Configure(EntityTypeBuilder<DictionaryGroupCFO> builder)
        {
            builder.HasKey(t => t.GroupCFOId);

            builder.ToTable("Dictionary_GroupCFO");

            builder.Property(t => t.OwnerId).HasColumnName("OwnerId");
            builder.Property(t => t.RiskManagerId).HasColumnName("RiskManagerId");
            builder.Property(t => t.Name).HasColumnName("Name");
            builder.Property(t => t.Code).HasColumnName("Code");
            builder.Property(t => t.DisplayOrder).HasColumnName("Duration");
            builder.Property(t => t.ZGDId).HasColumnName("ZGDId");

            builder.Property(t => t.Owner).IsRequired();
            builder.HasOne(t => t.Owner)
                .WithMany(t => t.GroupCFOs)
                .HasForeignKey(t => t.OwnerId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.RiskManager)
                .WithMany(t => t.GroupCFORiskManagers)
                .HasForeignKey(t => t.RiskManagerId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.ZGD)
                .WithMany(t => t.GroupCFOZGDs)
                .HasForeignKey(t => t.ZGDId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
