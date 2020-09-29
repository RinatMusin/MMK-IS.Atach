using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class TaskActionConfiguration : IEntityTypeConfiguration<TaskAction>
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
