using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
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
