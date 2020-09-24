using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities.Dictionary;

namespace MMK_IS.Atach.Domain.Entities.Mapping.Dictionary
{
    public class CargoCarrierMap : IEntityTypeConfiguration<CargoCarrier>
    {
        public void Configure(EntityTypeBuilder<CargoCarrier> builder)
        {
            builder.HasKey(t => t.CargoCarrierId);

            builder.ToTable("Dictionary_CargoCarrier");

            builder.Property(t => t.Name).HasColumnName("Name");
        }
    }
}