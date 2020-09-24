using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    public class DepartmentMap : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(t => t.DepartmentId);

            builder.ToTable("Department");

            builder.Property(t => t.Name).HasColumnName("Name").HasColumnType("varchar");
            builder.Property(t => t.DisplayOrder).HasColumnName("DisplayOrder");
            builder.Property(t => t.Image).HasColumnName("Image");
        }
    }
}