using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class KonturCloudTransactionMap : IEntityTypeConfiguration<KonturCloudTransaction>
    {
        public void Configure(EntityTypeBuilder<KonturCloudTransaction> builder)
        {
            builder.HasKey(t => t.KonturCloudTransactionId);

            builder.ToTable("KonturCloudTransaction");

            builder.Property(t => t.TransactionId).HasColumnName("TransactionId");
            builder.Property(t => t.IsFinished).HasColumnName("IsFinished");
            builder.Property(t => t.InProcessing).HasColumnName("InProcessing");
            builder.Property(t => t.DocumentId).HasColumnName("DocumentId");
            builder.Property(t => t.TaskId).HasColumnName("TaskId");
            builder.Property(t => t.CreationTime).HasColumnName("CreationTime");
            builder.Property(t => t.CompletionTime).HasColumnName("CompletionTime").IsRequired(false);

            builder.Property(t => t.Document).IsRequired();
            builder.HasOne(t => t.Document)
                .WithMany()
                .HasForeignKey(t => t.DocumentId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(t => t.Task).IsRequired();
            builder.HasOne(t => t.Task)
              .WithMany()
              .HasForeignKey(d => d.TaskId)
              .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
