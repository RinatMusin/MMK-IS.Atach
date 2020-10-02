using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class FieldDependencyConfiguration : IEntityTypeConfiguration<FieldDependency>
    {
        public void Configure(EntityTypeBuilder<FieldDependency> builder)
        {
            // Primary Key
            builder.HasKey(t => t.FieldDependencyId);

            // Properties
            // Table & Column Mappings
            builder.ToTable("Field_Dependency");

            builder.Property(t => t.MainFieldId).HasColumnName("MainFieldId");
            builder.Property(t => t.DependencyFieldId).HasColumnName("DependencyFieldId");

            // Relationships
            builder.HasOne(t => t.MainField).WithOne().IsRequired();
            builder.HasOne(t => t.MainField)
                .WithMany(t => t.MainFields)
                .HasForeignKey(d => d.MainFieldId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.DependencyField).WithOne().IsRequired();
            builder.HasOne(t => t.DependencyField)
                .WithMany(t => t.DependencyFields)
                .HasForeignKey(d => d.DependencyFieldId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
