using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities.Dictionary;

namespace MMK_IS.Atach.Persistence.Configurations.Dictionary
{
    public class DepartmentDirectoryConfiguration : IEntityTypeConfiguration<DictionaryDepartmentDirectory>
    {
        public void Configure(EntityTypeBuilder<DictionaryDepartmentDirectory> builder)
        {
           builder.HasKey(t => t.DepartmentDirectoryId);

            builder.ToTable("Dictionary_DepartmentDirectory");

            builder.Property(t => t.DepartmentDirectory).HasColumnName("DepartmentDirectory");
            builder.Property(t => t.DepartmentManagerId).HasColumnName("DepartmentManagerId");

            builder.HasOne(t => t.DepartmentManager).WithOne().IsRequired();
            builder.HasOne(t => t.DepartmentManager)
                .WithMany(t => t.DepartmentManagers)
                .HasForeignKey(t => t.DepartmentManagerId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
