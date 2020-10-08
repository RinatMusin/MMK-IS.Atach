using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class FileProcessingStatusConfiguration : IEntityTypeConfiguration<FileProcessingStatus>
    {
        public void Configure(EntityTypeBuilder<FileProcessingStatus> builder)
        {
            builder.ToTable("File_Processing_Status");

            builder.HasKey(t => t.StatusId);

            builder.Property(t => t.StatusId).HasColumnName("StatusId");
            builder.Property(t => t.Name).HasColumnName("Name").HasMaxLength(8000);
            builder.Property(t => t.IsTerminal).HasColumnName("IsTerminal");
        }
    }
}
