using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class FileEditConfiguration : IEntityTypeConfiguration<FileEdit>
    {
        public void Configure(EntityTypeBuilder<FileEdit> builder)
        {
            // Primary Key
            builder.HasKey(t => t.FileEditId);

            // Properties
            // Table & Column Mappings
            builder.ToTable("File_Edit");

            builder.Property(t => t.Name).HasColumnName("Name").HasMaxLength(8000); 
            builder.Property(t => t.Date).HasColumnName("Date").HasMaxLength(8000);
        }

    }
}
