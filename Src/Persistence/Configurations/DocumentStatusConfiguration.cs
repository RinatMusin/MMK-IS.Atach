using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class DocumentStatusConfiguration : IEntityTypeConfiguration<DocumentStatus>
    {
        public void Configure(EntityTypeBuilder<DocumentStatus> builder)
        {
            builder.HasKey(t => t.DocumentStatusId);

            builder.ToTable("Document_Status");
            builder.Property(t => t.TypeStatus).HasColumnName("TypeStatus").HasMaxLength(8000);
            builder.Property(t => t.Name).HasColumnName("Name").HasMaxLength(8000);
            builder.Property(t => t.StatusColor).HasColumnName("StatusColor").HasMaxLength(8000);
            builder.Property(t => t.CenterPanelType).HasColumnName("CenterPanelType").HasMaxLength(8000);
            builder.Property(t => t.RightPanelType).HasColumnName("RightPanelType").HasMaxLength(8000);
        }
    }
}
