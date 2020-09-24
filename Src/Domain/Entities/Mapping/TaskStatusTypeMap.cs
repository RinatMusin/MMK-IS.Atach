using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    public class TaskStatusTypeMap : IEntityTypeConfiguration<TaskStatusType>
    {
        public void Configure(EntityTypeBuilder<TaskStatusType> builder)
        {
            // Primary Key
            builder.HasKey(t => t.TaskStatusTypeId);

            // Properties
            // Table & Column Mappings
            builder.ToTable("Task_Status_Type");

            builder.Property(t => t.Name).HasColumnName("Name").HasColumnType("varchar");
        }
    }
}
