using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{

    public class SignDocsQueueMap : IEntityTypeConfiguration<SignDocsQueue>
    {
        public void Configure(EntityTypeBuilder<SignDocsQueue> builder)
        {
            builder.HasKey(t => t.MemberId);

            builder.ToTable("SignDocsQueue");

            builder.Property(t => t.Token).HasColumnName("Token").HasColumnType("varchar");
            builder.Property(t => t.User).HasColumnName("User").HasColumnType("varchar");
            builder.Property(t => t.Password).HasColumnName("Password").HasColumnType("varchar");
            builder.Property(t => t.PinCode).HasColumnName("PinCode").HasColumnType("varchar");
            builder.Property(t => t.DocumentId).HasColumnName("DocumentId");
            builder.Property(t => t.DocsPath).HasColumnName("DocsPath").HasColumnType("varchar");
            builder.Property(t => t.DocName).HasColumnName("DocName").HasColumnType("varchar");
            builder.Property(t => t.IsActive).HasColumnName("IsActive");
            builder.Property(t => t.IsConfirmed).HasColumnName("IsConfirmed");
            builder.Property(t => t.IsFinished).HasColumnName("IsFinished");
            builder.Property(t => t.LastRequest).HasColumnName("LastRequest");
            builder.Property(t => t.CertUserName).HasColumnName("CertUserName").HasColumnType("varchar");
            builder.Property(t => t.CertSerialNumber).HasColumnName("CertSerialNumber").HasColumnType("varchar");
            builder.Property(t => t.CertDateFrom).HasColumnName("CertDateFrom").HasColumnType("varchar");
            builder.Property(t => t.CertDateTo).HasColumnName("CertDateTo").HasColumnType("varchar");
            builder.Property(t => t.UniqueTransactionId).HasColumnName("UniqueTransactionId").IsOptional();
        }

    }
}




