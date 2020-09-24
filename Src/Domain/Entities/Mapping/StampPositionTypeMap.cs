using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    public class StampPositionTypeMap : IEntityTypeConfiguration<StampPositionType>
    {
        public void Configure(EntityTypeBuilder<StampPositionType> builder)
        {
            builder.HasKey(t => t.StampPositionTypeId);

            builder.ToTable("StampPosition_Type");

            builder.Property(t => t.Type).HasColumnName("Type");
            builder.Property(t => t.Text).HasColumnName("Text");

        }
    }
}
