using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    public class FieldCounterPartyTypeMap : IEntityTypeConfiguration<FieldCounterPartyType>
    {
        public void Configure(EntityTypeBuilder<FieldCounterPartyType> builder)
        {
            builder.HasKey(t => t.FieldCounterPartyId);

            builder.ToTable("FieldCounterPartyType");

            builder.Property(t => t.CounterPartyTypeId).HasColumnName("CounterPartyTypeId");
            builder.Property(t => t.FiedId).HasColumnName("FiedId");

            builder.HasRequired(t => t.CounterPartyType)
                .WithMany(t => t.FieldCounterParties)
                .HasForeignKey(t => t.CounterPartyTypeId)
                .WillCascadeOnDelete(true);

            builder.HasRequired(t => t.Field)
                .WithMany(t => t.FieldCounterParties)
                .HasForeignKey(t => t.FiedId)
                .WillCascadeOnDelete(true);
        }
    }
}
