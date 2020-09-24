using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    public class FileEditMap : IEntityTypeConfiguration<FileEdit>
    {
        public void Configure(EntityTypeBuilder<FileEdit> builder)
        {
            // Primary Key
            builder.HasKey(t => t.FileEditId);

            // Properties
            // Table & Column Mappings
            builder.ToTable("File_Edit");

            builder.Property(t => t.Name).HasColumnName("Name").HasColumnType("varchar"); 
            builder.Property(t => t.Date).HasColumnName("Date").HasColumnType("varchar");
        }

    }
}
