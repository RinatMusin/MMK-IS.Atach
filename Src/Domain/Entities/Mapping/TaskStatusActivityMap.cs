using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    public class TaskStatusActivityMap : IEntityTypeConfiguration<TaskStatusActivity>
    {
        public void Configure(EntityTypeBuilder<TaskStatusActivity> builder)
        {
            builder.HasKey(t => t.TaskStatusActivityId);

            builder.ToTable("Task_Status_Activity");

            builder.Property(t => t.ActivityId).HasColumnName("ActivityId");
            builder.Property(t => t.TaskStatusId).HasColumnName("TaskStatusId");

            builder.HasRequired(t => t.Activity)
                .WithMany(t => t.TaskStatusActivities)
                .HasForeignKey(t => t.ActivityId);

            builder.HasRequired(t => t.TaskStatus)
              .WithMany(t => t.TaskStatusActivities)
              .HasForeignKey(t => t.TaskStatusId);
        }
    }
}
