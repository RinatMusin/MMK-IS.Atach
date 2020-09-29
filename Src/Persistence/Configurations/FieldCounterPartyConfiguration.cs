using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class FieldCounterPartyTypeConfiguration : IEntityTypeConfiguration<FieldCounterPartyType>
    {
        public void Configure(EntityTypeBuilder<FieldCounterPartyType> builder)
        {
            builder.HasKey(t => t.FieldCounterPartyId);

            builder.ToTable("FieldCounterPartyType");

            builder.Property(t => t.CounterPartyTypeId).HasColumnName("CounterPartyTypeId");
            builder.Property(t => t.FiedId).HasColumnName("FiedId");

            builder.Property(t => t.CounterPartyType).IsRequired();
            builder.HasOne(t => t.CounterPartyType)
                .WithMany(t => t.FieldCounterParties)
                .HasForeignKey(t => t.CounterPartyTypeId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(t => t.Field).IsRequired();
            builder.HasOne(t => t.Field)
                .WithMany(t => t.FieldCounterParties)
                .HasForeignKey(t => t.FiedId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
