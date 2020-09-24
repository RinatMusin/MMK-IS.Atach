using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    public class FileTypeMap : IEntityTypeConfiguration<FileType>
    {
        public void Configure(EntityTypeBuilder<FileType> builder)
        {
            builder.HasKey(t => t.FileTypeId);

            builder.ToTable("File_Type");

            builder.Property(t => t.Name).HasColumnName("Name").HasColumnType("varchar");
        }
    }
}
