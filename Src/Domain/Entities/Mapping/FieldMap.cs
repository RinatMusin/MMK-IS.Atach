using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    public class FieldMap : IEntityTypeConfiguration<Field>
    {
        public void Configure(EntityTypeBuilder<Field> builder)
        {
            builder.HasKey(t => t.FieldId);

            // Properties
            // Table & Column Mappings
            builder.ToTable("Field");

            builder.Property(t => t.FieldTypeId).HasColumnName("FieldTypeId");   
            builder.Property(t => t.TargetTypeId).HasColumnName("TargetTypeId");   

            builder.Property(t => t.Name).HasColumnName("Name").HasColumnType("varchar"); 
            builder.Property(t => t.SystemName).HasColumnName("SystemName").HasColumnType("varchar"); 
            builder.Property(t => t.DefaultValue).HasColumnName("DefaultValue").HasColumnType("varchar");
            builder.Property(t => t.DataUrl).HasColumnName("DataUrl").HasColumnType("varchar");


            builder.HasRequired(t => t.FieldTargetType)
                .WithMany(t => t.Fields)
                .HasForeignKey(t => t.TargetTypeId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasRequired(t => t.FieldType)
                .WithMany(t => t.Fields)
                .HasForeignKey(t => t.FieldTypeId)
                .OnDelete(DeleteBehavior.Cascade);

        }

    }
}
