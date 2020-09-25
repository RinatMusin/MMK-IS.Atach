using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities.Dictionary;

namespace MMK_IS.Atach.Persistence.Configurations.Dictionary
{
    public class CargoNameMap : IEntityTypeConfiguration<CargoName>
    {
        public void Configure(EntityTypeBuilder<CargoName> builder)
        {
            builder.HasKey(t => t.CargoNameId);

            builder.ToTable("Dictionary_CargoName");

            builder.Property(t => t.Name).HasColumnName("Name");
        }
    }
}