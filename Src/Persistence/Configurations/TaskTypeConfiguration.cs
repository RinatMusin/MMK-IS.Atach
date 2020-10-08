using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class TaskTypeConfiguration : IEntityTypeConfiguration<TaskType>
    {
        public void Configure(EntityTypeBuilder<TaskType> builder)
        {
            // Primary Key
            builder.HasKey(t => t.TaskTypeId);

            // Properties
            // Table & Column Mappings
            builder.ToTable("Task_Type");

            builder.Property(t => t.Name).HasColumnName("Name").HasMaxLength(8000);
            // Relationships

        }

    }
}
