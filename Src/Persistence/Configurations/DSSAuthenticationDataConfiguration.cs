using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class DSSAuthenticationDataConfiguration : IEntityTypeConfiguration<DSSAuthenticationData>
    {
        public void Configure(EntityTypeBuilder<DSSAuthenticationData> builder)
        {
            builder.HasKey(t => t.DSSAuthenticationDataId);

            builder.ToTable("DSSAuthenticationData");

            builder.Property(t => t.Username).HasColumnName("Username");
            builder.Property(t => t.Password).HasColumnName("Password");
            builder.Property(t => t.PersonalIdentificationNumber).HasColumnName("PersonalIdentificationNumber");
            builder.Property(t => t.HashSigning).HasColumnName("HashSigning");

            builder.Property(t => t.Thumbprint).HasColumnName("Thumbprint");
            builder.Property(t => t.Subject).HasColumnName("Subject");
            builder.Property(t => t.ExpirationDate).HasColumnName("ExpirationDate").IsRequired(false);
            builder.Property(t => t.KonturCertificate).HasColumnName("KonturCertificate").IsRequired(false);
        }
    }
}
