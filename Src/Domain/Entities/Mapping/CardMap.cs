using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    public class CardMap : IEntityTypeConfiguration<Card>
    {
        public void Configure(EntityTypeBuilder<Card> builder)
        {
            // Primary Key
            builder.HasKey(t => t.CardId);

            // Properties
            // Table & Column Mappings
            builder.ToTable("Card");

            builder.Property(t => t.ParentCardId).HasColumnName("ParentCardId");
            builder.Property(t => t.DocumentTypeId).HasColumnName("DocumentTypeId");
            builder.Property(t => t.Name).HasColumnName("Name").HasColumnType("varchar"); ;
            builder.Property(t => t.Description).HasColumnName("Description").HasColumnType("varchar"); ;
            builder.Property(t => t.IsTemplate).HasColumnName("IsTemplate");

            // Relationships
            builder.HasOptional(t => t.ParentCard)
                .WithMany()
                .HasForeignKey(d => d.ParentCardId)
                .WillCascadeOnDelete(false);

            builder.HasRequired(t => t.DocumentType)
                .WithMany(t => t.Cards)
                .HasForeignKey(d => d.DocumentTypeId)
                .WillCascadeOnDelete(true);

        }
    }
}
