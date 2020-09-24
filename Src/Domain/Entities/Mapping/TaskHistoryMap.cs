﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    public class TaskHistoryMap : IEntityTypeConfiguration<TaskHistory>
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

            builder.HasRequired(t => t.Task)
                .WithMany(t => t.TaskHistories)
                .HasForeignKey(t => t.TaskId)
                .WillCascadeOnDelete(true);

            builder.HasRequired(t => t.TaskAction)
              .WithMany(t => t.TaskHistories)
              .HasForeignKey(t => t.TaskActionId)
              .WillCascadeOnDelete(false);

            builder.HasOptional(t => t.CreatedUser)
            .WithMany(t => t.TaskHistoryCreators)
            .HasForeignKey(t => t.CreatedUserId)
            .WillCascadeOnDelete(false);

            builder.HasOptional(t => t.CanceledUser)
            .WithMany(t => t.TaskHistories)
            .HasForeignKey(t => t.CanceledUserId)
            .WillCascadeOnDelete(false);

        }
    }
}