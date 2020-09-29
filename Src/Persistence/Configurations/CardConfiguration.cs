using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
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
            builder.HasOne(t => t.ParentCard)
                .WithMany()
                .HasForeignKey(d => d.ParentCardId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(t => t.DocumentType).IsRequired();
            builder.HasOne(t => t.DocumentType)
                .WithMany(t => t.Cards)
                .HasForeignKey(d => d.DocumentTypeId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
