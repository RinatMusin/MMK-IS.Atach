using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    public class FileMap : IEntityTypeConfiguration<File>
    {
        public void Configure(EntityTypeBuilder<File> builder)
        {
            builder.HasKey(t => t.FileId);

            builder.ToTable("File");

            builder.Property(t => t.UploadedUserId).HasColumnName("UploadedUserId");
            builder.Property(t => t.ParentFileId).HasColumnName("ParentFileId");
            builder.Property(t => t.FileTypeId).HasColumnName("FileTypeId");
            builder.Property(t => t.Name).HasColumnName("Name").HasColumnType("varchar"); ;
            builder.Property(t => t.Path).HasColumnName("Link").HasColumnType("varchar"); ;
            builder.Property(t => t.IsDeleted).HasColumnName("IsDeleted");
            builder.Property(t => t.Version).HasColumnName("Version");

            builder.Property(t => t.DeleteDate).HasColumnName("DeleteDate");
            builder.Property(t => t.CreationDate).HasColumnName("CreationDate");
            builder.Property(t => t.LastUpdate).HasColumnName("LastUpdate");

            builder.HasOne(t => t.ParentFile)
                .WithMany()
                .HasForeignKey(t => t.ParentFileId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasRequired(t => t.FileType)
                .WithMany(t => t.Files)
                .HasForeignKey(t => t.FileTypeId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.UploadedUser)
                .WithMany(t=>t.Files)
                .HasForeignKey(t => t.UploadedUserId)
                .OnDelete(DeleteBehavior.Cascade);
        }

    }
}
