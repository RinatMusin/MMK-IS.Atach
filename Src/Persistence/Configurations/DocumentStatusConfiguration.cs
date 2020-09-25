using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class DocumentStatusMap : IEntityTypeConfiguration<DocumentStatus>
    {
        public void Configure(EntityTypeBuilder<DocumentStatus> builder)
        {
            builder.HasKey(t => t.DocumentStatusId);

            builder.ToTable("Document_Status");
            builder.Property(t => t.TypeStatus).HasColumnName("TypeStatus").HasColumnType("varchar");
            builder.Property(t => t.Name).HasColumnName("Name").HasColumnType("varchar");
            builder.Property(t => t.StatusColor).HasColumnName("StatusColor").HasColumnType("varchar");
            builder.Property(t => t.CenterPanelType).HasColumnName("CenterPanelType").HasColumnType("varchar");
            builder.Property(t => t.RightPanelType).HasColumnName("RightPanelType").HasColumnType("varchar");
        }
    }
}
