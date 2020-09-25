using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
   public class FieldTypeMap : IEntityTypeConfiguration<FieldType>
    {
        public void Configure(EntityTypeBuilder<FieldType> builder)
        {
            // Primary Key
            builder.HasKey(t => t.FieldTypeId);

            // Properties
            // Table & Column Mappings
            builder.ToTable("Field_Type");

            builder.Property(t => t.Name).HasColumnName("Name").HasColumnType("varchar"); ;  
        }
    }
}
