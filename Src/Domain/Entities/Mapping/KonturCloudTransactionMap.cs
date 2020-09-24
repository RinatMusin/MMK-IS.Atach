using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
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
            builder.Property(t => t.CompletionTime).HasColumnName("CompletionTime").IsOptional();

            builder.HasRequired(t => t.Document)
                .WithMany()
                .HasForeignKey(t => t.DocumentId)
                .WillCascadeOnDelete(false);

            builder.HasRequired(t => t.Task)
              .WithMany()
              .HasForeignKey(d => d.TaskId)
              .WillCascadeOnDelete(false);
        }
    }
}
