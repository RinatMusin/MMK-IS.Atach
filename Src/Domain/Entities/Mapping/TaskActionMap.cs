using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    public class TaskActionMap : IEntityTypeConfiguration<TaskAction>
    {
        public void Configure(EntityTypeBuilder<TaskAction> builder)
        {
            builder.HasKey(t => t.TaskActionId);

            builder.ToTable("Task_Action");

            builder.Property(t => t.Name).HasColumnName("Name");
            builder.Property(t => t.RusName).HasColumnName("RusName");

        }
    }
}
