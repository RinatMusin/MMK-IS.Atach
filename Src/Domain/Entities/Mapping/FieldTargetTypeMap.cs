using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    public class FieldTargetTypeMap : IEntityTypeConfiguration<FieldTargetType>
    {
        public void Configure(EntityTypeBuilder<FieldTargetType> builder)
        {
            builder.HasKey(t => t.FieldTargetTypeId);

            builder.ToTable("Field_Target_Type");

            builder.Property(t => t.Name).HasColumnName("Name").HasColumnType("varchar");
        }
    }
}
