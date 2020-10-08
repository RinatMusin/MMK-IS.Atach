using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class FileTypeConfiguration : IEntityTypeConfiguration<FileType>
    {
        public void Configure(EntityTypeBuilder<FileType> builder)
        {
            builder.HasKey(t => t.FileTypeId);

            builder.ToTable("File_Type");

            builder.Property(t => t.Name).HasColumnName("Name").HasMaxLength(8000);
        }
    }
}
