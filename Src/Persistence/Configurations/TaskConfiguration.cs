using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class TaskConfiguration : IEntityTypeConfiguration<TaskEntity>
    {
        public void Configure(EntityTypeBuilder<TaskEntity> builder)
        {
            builder.ToTable("Task");

            builder.HasKey(t => t.TaskId);

            builder.Property(t => t.DocumentId).HasColumnName("DocumentId");
            builder.Property(t => t.Resolution).HasColumnName("Resolution").HasMaxLength(8000);
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

            builder.HasOne(t => t.Document).WithOne().IsRequired();
            builder.HasOne(t => t.Document)
                .WithMany(t => t.Tasks)
                .HasForeignKey(t => t.DocumentId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.ParentTask)
                .WithMany()
                .HasForeignKey(t => t.ParentTaskId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.TaskStatus).WithOne().IsRequired();
            builder.HasOne(t => t.TaskStatus)
                .WithMany(t => t.TaskEntities)
                .HasForeignKey(t => t.TaskStatusId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.TaskType).WithOne().IsRequired();
            builder.HasOne(t => t.TaskType)
                .WithMany(t => t.TaskEntities)
                .HasForeignKey(t => t.TaskTypeId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.FromUser).WithOne().IsRequired();
            builder.HasOne(t => t.FromUser)
               .WithMany(t => t.TasksFromUser)
               .HasForeignKey(t => t.FromUserId)
               .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.ToUser).WithOne().IsRequired();
            builder.HasOne(t => t.ToUser)
               .WithMany(t => t.TasksToUser)
               .HasForeignKey(t => t.ToUserId)
               .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.ReplacementUser)
                .WithMany(t => t.TaskReplacementUsers)
                .HasForeignKey(t => t.ReplacementUserId)
                .OnDelete(DeleteBehavior.Cascade);
            
            builder.HasOne(t => t.Workplace).WithOne().IsRequired();
            builder.HasOne(t => t.Workplace)
               .WithMany(t => t.TaskEntities)
               .HasForeignKey(t => t.WorkplaceId)
               .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.Card)
                .WithMany(t => t.Tasks)
                .HasForeignKey(t => t.CardId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
