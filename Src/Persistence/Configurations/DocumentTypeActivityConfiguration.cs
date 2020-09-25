using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class DocumentTypeActivityMap : IEntityTypeConfiguration<DocumentTypeActivity>
    {
        public void Configure(EntityTypeBuilder<DocumentTypeActivity> builder)
        {
            builder.HasKey(t => t.DocumentTypeActivityId);

            builder.ToTable("Document_Type_Activity");

            builder.Property(t => t.ActivityId).HasColumnName("ActivityId");
            builder.Property(t => t.DocumentTypeId).HasColumnName("DocumentTypeId");

            builder.HasRequired(t => t.Activity)
                .WithMany(t => t.DocumentTypeActivities)
                .HasForeignKey(t => t.ActivityId)
                .WillCascadeOnDelete(true);

            builder.HasRequired(t => t.DocumentType)
                .WithMany(t => t.DocumentTypeActivities)
                .HasForeignKey(t => t.DocumentTypeId)
                .WillCascadeOnDelete(true);
        }

    }


}
