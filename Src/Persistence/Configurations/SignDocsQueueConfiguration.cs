using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{

    public class SignDocsQueueConfiguration : IEntityTypeConfiguration<SignDocsQueue>
    {
        public void Configure(EntityTypeBuilder<SignDocsQueue> builder)
        {
            builder.HasKey(t => t.MemberId);

            builder.ToTable("SignDocsQueue");

            builder.Property(t => t.Token).HasColumnName("Token").HasMaxLength(8000);
            builder.Property(t => t.User).HasColumnName("User").HasMaxLength(8000);
            builder.Property(t => t.Password).HasColumnName("Password").HasMaxLength(8000);
            builder.Property(t => t.PinCode).HasColumnName("PinCode").HasMaxLength(8000);
            builder.Property(t => t.DocumentId).HasColumnName("DocumentId");
            builder.Property(t => t.DocsPath).HasColumnName("DocsPath").HasMaxLength(8000);
            builder.Property(t => t.DocName).HasColumnName("DocName").HasMaxLength(8000);
            builder.Property(t => t.IsActive).HasColumnName("IsActive");
            builder.Property(t => t.IsConfirmed).HasColumnName("IsConfirmed");
            builder.Property(t => t.IsFinished).HasColumnName("IsFinished");
            builder.Property(t => t.LastRequest).HasColumnName("LastRequest");
            builder.Property(t => t.CertUserName).HasColumnName("CertUserName").HasMaxLength(8000);
            builder.Property(t => t.CertSerialNumber).HasColumnName("CertSerialNumber").HasMaxLength(8000);
            builder.Property(t => t.CertDateFrom).HasColumnName("CertDateFrom").HasMaxLength(8000);
            builder.Property(t => t.CertDateTo).HasColumnName("CertDateTo").HasMaxLength(8000);
            builder.Property(t => t.UniqueTransactionId).HasColumnName("UniqueTransactionId").IsRequired(false);
        }

    }
}




