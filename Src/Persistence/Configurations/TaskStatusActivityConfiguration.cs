using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class TaskStatusActivityMap : IEntityTypeConfiguration<TaskStatusActivity>
    {
        public void Configure(EntityTypeBuilder<TaskStatusActivity> builder)
        {
            builder.HasKey(t => t.TaskStatusActivityId);

            builder.ToTable("Task_Status_Activity");

            builder.Property(t => t.ActivityId).HasColumnName("ActivityId");
            builder.Property(t => t.TaskStatusId).HasColumnName("TaskStatusId");

            builder.Property(t => t.Activity).IsRequired();
            builder.HasOne(t => t.Activity)
                .WithMany(t => t.TaskStatusActivities)
                .HasForeignKey(t => t.ActivityId);

            builder.Property(t => t.TaskStatus).IsRequired();
            builder.HasOne(t => t.TaskStatus)
              .WithMany(t => t.TaskStatusActivities)
              .HasForeignKey(t => t.TaskStatusId);            
        }
    }
}
