using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class TaskHistoryConfiguration : IEntityTypeConfiguration<TaskHistory>
    {
        public void Configure(EntityTypeBuilder<TaskHistory> builder)
        {
            builder.HasKey(t => t.TaskHistoryId);

            builder.ToTable("Task_History");

            builder.Property(t => t.TaskId).HasColumnName("TaskId");
            builder.Property(t => t.TaskActionId).HasColumnName("TaskActionId");
            builder.Property(t => t.CreatedUserId).HasColumnName("CreatedUserId");
            builder.Property(t => t.CanceledUserId).HasColumnName("CanceledUserId");
            builder.Property(t => t.Feedback).HasColumnName("FeedBack");
            builder.Property(t => t.TaskId).HasColumnName("TaskId");
            builder.Property(t => t.NewExecutionDate).HasColumnName("NewExecutionDate");

            builder.Property(t => t.Task).IsRequired();
            builder.HasOne(t => t.Task)
                .WithMany(t => t.TaskHistories)
                .HasForeignKey(t => t.TaskId)
                  .OnDelete(DeleteBehavior.Cascade);

            builder.Property(t => t.TaskAction).IsRequired();
            builder.HasOne(t => t.TaskAction)
              .WithMany(t => t.TaskHistories)
              .HasForeignKey(t => t.TaskActionId)
              .OnDelete(DeleteBehavior.Cascade);
            
            builder.HasOne(t => t.CreatedUser)
            .WithMany(t => t.TaskHistoryCreators)
            .HasForeignKey(t => t.CreatedUserId)
            .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.CanceledUser)
            .WithMany(t => t.TaskHistories)
            .HasForeignKey(t => t.CanceledUserId)
            .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
