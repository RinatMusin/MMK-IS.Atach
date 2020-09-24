using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    public class FilePageMap : IEntityTypeConfiguration<FilePage>
    {
        public void Configure(EntityTypeBuilder<FilePage> builder)
        {
            // Primary Key
            builder.HasKey(t => t.FilePageId);

            // Properties
            // Table & Column Mappings
            builder.ToTable("File_Page");

            builder.Property(t => t.FileId).HasColumnName("FileId");
            builder.Property(t => t.PageImage).HasColumnName("FirstPageImage");
            builder.Property(t => t.PageNumber).HasColumnName("PageCount");
            builder.Property(t => t.CreateDate).HasColumnName("InsertDate");

            // Relationships
            builder.HasRequired(t => t.File)
                .WithMany(t => t.FilePages)
                .HasForeignKey(d => d.FileId)
                .WillCascadeOnDelete(true);

        }
    }
}
