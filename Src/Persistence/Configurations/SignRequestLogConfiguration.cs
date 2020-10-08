using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{

    public class SignRequestLogConfiguration : IEntityTypeConfiguration<SignRequestLog>
    {
        public void Configure(EntityTypeBuilder<SignRequestLog> builder)
        {
            builder.HasKey(t => t.LogId);

            builder.ToTable("SignRequestLog");

            builder.Property(t => t.RequestURL).HasColumnName("RequestURL").HasMaxLength(8000);
            builder.Property(t => t.Authorization).HasColumnName("Authorization").HasMaxLength(8000);
            builder.Property(t => t.RequestContentType).HasColumnName("RequestContentType").HasMaxLength(8000);
            builder.Property(t => t.RequestContent).HasColumnName("RequestContent");
            builder.Property(t => t.RequestQuery).HasColumnName("RequestQuery");
            builder.Property(t => t.RequestMethod).HasColumnName("RequestMethod").HasMaxLength(8000);
            builder.Property(t => t.ResponseContent).HasColumnName("ResponseContent");
            builder.Property(t => t.ResponseContentType).HasColumnName("ResponseContentType").HasMaxLength(8000);
            builder.Property(t => t.ResponseStatusCode).HasColumnName("ResponseStatusCode").HasMaxLength(8000);
            builder.Property(t => t.ResponseTimestamp).HasColumnName("CreationDate");
            builder.Property(t => t.RequestTimestamp).HasColumnName("LastUpdateDate");
            builder.Property(t => t.DocumentId).IsRequired();
            builder.Property(t => t.UniqueTransactionId).HasColumnName("UniqueTransactionId").IsRequired(false);
        }

    }
}




