using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    public class TaskTypeMap : IEntityTypeConfiguration<TaskType>
    {
        public void Configure(EntityTypeBuilder<TaskType> builder)
        {
            // Primary Key
            builder.HasKey(t => t.TaskTypeId);

            // Properties
            // Table & Column Mappings
            builder.ToTable("Task_Type");

            builder.Property(t => t.Name).HasColumnName("Name").HasColumnType("varchar"); ;
            // Relationships

        }

    }
}
