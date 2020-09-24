using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    public class TaskMap : IEntityTypeConfiguration<TaskEntity>
    {
        public void Configure(EntityTypeBuilder<TaskEntity> builder)
        {
            builder.ToTable("Task");

            builder.HasKey(t => t.TaskId);

            builder.Property(t => t.DocumentId).HasColumnName("DocumentId");
            builder.Property(t => t.Resolution).HasColumnName("Resolution").HasColumnType("varchar");
            builder.Property(t => t.ParentTaskId).HasColumnName("ParentTaskId");
            builder.Property(t => t.TaskStatusId).HasColumnName("TaskStatusId");
            builder.Property(t => t.TaskTypeId).HasColumnName("TaskTypeId");
            builder.Property(t => t.ToUserId).HasColumnName("ToUserId");
            builder.Property(t => t.ReplacementUserId).HasColumnName("ReplacementUserId");
            builder.Property(t => t.FromUserId).HasColumnName("FromUserId");
            builder.Property(t => t.CardId).HasColumnName("CardId");
            builder.Property(t => t.IsControl).HasColumnName("IsControl");
            builder.Property(t => t.IsShowRedEye).HasColumnName("IsShowRedEyes");
            builder.Property(t => t.IsNewTask).HasColumnName("IsNewTask");
            builder.Property(t => t.IsVisible).HasColumnName("IsVisible");
            builder.Property(t => t.CompleteDate).HasColumnName("CompleteDate");
            builder.Property(t => t.CreationDate).HasColumnName("CreationDate");
            builder.Property(t => t.LastUpdate).HasColumnName("LastUpdate");
            builder.Property(t => t.DateOfExecution).HasColumnName("DateOfExecution");

            builder.HasRequired(t => t.Document)
                .WithMany(t => t.Tasks)
                .HasForeignKey(t => t.DocumentId)
                .WillCascadeOnDelete(true);

            builder.HasOptional(t => t.ParentTask)
                .WithMany()
                .HasForeignKey(t => t.ParentTaskId)
                .WillCascadeOnDelete(true);

            builder.HasRequired(t => t.TaskStatus)
                .WithMany(t => t.TaskEntities)
                .HasForeignKey(t => t.TaskStatusId)
                .WillCascadeOnDelete(false);

            builder.HasRequired(t => t.TaskType)
                .WithMany(t => t.TaskEntities)
                .HasForeignKey(t => t.TaskTypeId)
                .WillCascadeOnDelete(false);

            builder.HasRequired(t => t.FromUser)
               .WithMany(t => t.TasksFromUser)
               .HasForeignKey(t => t.FromUserId)
               .WillCascadeOnDelete(false);

            builder.HasRequired(t => t.ToUser)
               .WithMany(t => t.TasksToUser)
               .HasForeignKey(t => t.ToUserId)
               .WillCascadeOnDelete(false);

            builder.HasOptional(t => t.ReplacementUser)
                .WithMany(t => t.TaskReplacementUsers)
                .HasForeignKey(t => t.ReplacementUserId)
                .WillCascadeOnDelete(false);

            builder.HasRequired(t => t.Workplace)
               .WithMany(t => t.TaskEntities)
               .HasForeignKey(t => t.WorkplaceId)
               .WillCascadeOnDelete(false);

            builder.HasOptional(t => t.Card)
                .WithMany(t => t.Tasks)
                .HasForeignKey(t => t.CardId)
                .WillCascadeOnDelete(false);

        }
    }
}
