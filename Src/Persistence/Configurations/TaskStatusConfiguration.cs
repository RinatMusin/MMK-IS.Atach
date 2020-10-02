using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class TaskStatusConfiguration : IEntityTypeConfiguration<TaskStatus>
    {
        public void Configure(EntityTypeBuilder<TaskStatus> builder)
        {
            // Primary Key
            builder.HasKey(t => t.TaskStatusId);

            // Properties
            // Table & Column Mappings
            builder.ToTable("Task_Status");

            builder.Property(t => t.StatusTypeId).HasColumnName("StatusTypeId");
            builder.Property(t => t.Name).HasColumnName("Name").HasColumnType("varchar");
            builder.Property(t => t.StatusColor).HasColumnName("StatusColor").HasColumnType("varchar");
            builder.Property(t => t.RightPanelType).HasColumnName("RightPanelType").HasColumnType("varchar");
            builder.Property(t => t.CenterPanelType).HasColumnName("CenterPanelType").HasColumnType("varchar");
            builder.Property(t => t.SortOrder).HasColumnName("SortOrder");


            // Relationships
            builder.HasOne(t => t.TaskStatusType).WithOne().IsRequired();
            builder.HasOne(t => t.TaskStatusType)
                .WithMany(t => t.TaskStatuses)
                .HasForeignKey(d => d.StatusTypeId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}