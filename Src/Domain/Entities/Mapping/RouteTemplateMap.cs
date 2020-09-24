using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    public class RouteTemplateMap : IEntityTypeConfiguration<RouteTemplate>
    {
        public void Configure(EntityTypeBuilder<RouteTemplate> builder)
        {
            // Primary Key
            builder.HasKey(t => t.RouteTemplateId);

            // Properties
            // Table & Column Mappings
            builder.ToTable("Route_Template");

            builder.Property(t => t.DocumentTypeId).HasColumnName("DocumentTypeId");
            builder.Property(t => t.Name).HasColumnName("Name");


            // Relationships
            builder.HasRequired(t => t.DocumentType)
                .WithMany(t => t.RouteTemplates)
                .HasForeignKey(d => d.DocumentTypeId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}