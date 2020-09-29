using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities.Dictionary;

namespace MMK_IS.Atach.Persistence.Configurations.Dictionary
{
    public class PaymentTermsConfiguration : IEntityTypeConfiguration<DictionaryPaymentTerms>
    {
        public void Configure(EntityTypeBuilder<DictionaryPaymentTerms> builder)
        {
            builder.HasKey(t => t.PaymentId);

            builder.ToTable("Dictionary_PaymentTerms");

            builder.Property(t => t.PaymentCode).HasColumnName("PaymentCode");
            builder.Property(t => t.PaymentName).HasColumnName("PaymentName");
        }

    }
}
