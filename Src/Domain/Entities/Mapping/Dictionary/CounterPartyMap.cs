using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities.Dictionary;

namespace MMK_IS.Atach.Domain.Entities.Mapping.Dictionary
{
    public class CounterPartyMap : IEntityTypeConfiguration<DictionaryCounterParty>
    {
        public void Configure(EntityTypeBuilder<DictionaryCounterParty> builder)
        {
            builder.HasKey(t => t.CounterPartyId);

            builder.ToTable("Dictionary_CounterParty");

            builder.Property(t => t.Name).HasColumnName("Name");
            builder.Property(t => t.FullName).HasColumnName("FullName");
            builder.Property(t => t.Leader).HasColumnName("Leader");
            builder.Property(t => t.AccountantGeneral).HasColumnName("AccountantGeneral");
            builder.Property(t => t.CounterPartyTypeId).HasColumnName("CounterPartyTypeId");
            builder.Property(t => t.ContactPerson).HasColumnName("ContactPerson");
            builder.Property(t => t.Adress).HasColumnName("Adress");
            builder.Property(t => t.MailingAddress).HasColumnName("MailingAddress");
            builder.Property(t => t.LegalAddress).HasColumnName("LegalAddress");
            builder.Property(t => t.Telephone).HasColumnName("Telephone");
            builder.Property(t => t.Fax).HasColumnName("Fax");
            builder.Property(t => t.Email).HasColumnName("Email");
            builder.Property(t => t.SiteOfCompany).HasColumnName("SiteOfCompany");
            builder.Property(t => t.Telex).HasColumnName("Telex");
            builder.Property(t => t.Client).HasColumnName("Client");
            builder.Property(t => t.Provider).HasColumnName("Provider");
            builder.Property(t => t.Bank).HasColumnName("Bank");
            builder.Property(t => t.KPP).HasColumnName("KPP");
            builder.Property(t => t.PaymentAccount).HasColumnName("PaymentAccount");
            builder.Property(t => t.CorrAccount).HasColumnName("CorrAccount");
            builder.Property(t => t.BIC).HasColumnName("BIC");
            builder.Property(t => t.INN).HasColumnName("INN");
            builder.Property(t => t.OKPO).HasColumnName("OKPO");
            builder.Property(t => t.OKVED).HasColumnName("OKVED");
            builder.Property(t => t.Subdivision).HasColumnName("Subdivision");
            builder.Property(t => t.Employee).HasColumnName("Employee");
            builder.Property(t => t.SAPIdentification).HasColumnName("SAPIdentification");
            builder.Property(t => t.DateOfLastModification).HasColumnName("DateOfLastModification");

            builder.HasOne(t => t.CounterPartyType)
                .WithMany(t => t.DictionaryCounterParties)
                .HasForeignKey(t => t.CounterPartyTypeId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
