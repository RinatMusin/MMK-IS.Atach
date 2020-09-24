using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    public class FileProcessingStatusMap : IEntityTypeConfiguration<FileProcessingStatus>
    {
        public void Configure(EntityTypeBuilder<FileProcessingStatus> builder)
        {
            builder.ToTable("File_Processing_Status");

            builder.HasKey(t => t.StatusId);

            builder.Property(t => t.StatusId).HasColumnName("StatusId");
            builder.Property(t => t.Name).HasColumnName("Name").HasColumnType("varchar");
            builder.Property(t => t.IsTerminal).HasColumnName("IsTerminal");
        }
    }
}
