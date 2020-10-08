using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class FieldTargetTypeConfiguration : IEntityTypeConfiguration<FieldTargetType>
    {
        public void Configure(EntityTypeBuilder<FieldTargetType> builder)
        {
            builder.HasKey(t => t.FieldTargetTypeId);

            builder.ToTable("Field_Target_Type");

            builder.Property(t => t.Name).HasColumnName("Name").HasMaxLength(8000);
        }
    }
}
