using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    class RatingMap : IEntityTypeConfiguration<Rating>
    {
        public void Configure(EntityTypeBuilder<Rating> builder)
        {
            builder.HasKey(t => t.RatingId);

            builder.ToTable("Rating");

            builder.Property(t => t.Name).HasColumnName("name").HasColumnType("varchar");
        }
    }
}
