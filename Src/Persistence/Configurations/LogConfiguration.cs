using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class LogConfiguration : IEntityTypeConfiguration<Log>
    {
        public void Configure(EntityTypeBuilder<Log> builder)
        {
            builder.HasKey(t => t.LogId);

            builder.ToTable("log");

            builder.Property(t => t.RequestContentType).HasColumnName("request_content_type").HasMaxLength(8000);
            builder.Property(t => t.LogLevel).HasColumnName("log_level").HasMaxLength(8000);
            builder.Property(t => t.RequestDomain).HasColumnName("request_domain").HasMaxLength(8000);
            builder.Property(t => t.RequestController).HasColumnName("request_controller").HasMaxLength(8000);
            builder.Property(t => t.RequestQuery).HasColumnName("request_query").HasMaxLength(8000);
            builder.Property(t => t.RequestMethod).HasColumnName("request_method").HasMaxLength(8000);
            builder.Property(t => t.Message).HasColumnName("message").HasMaxLength(8000);
            builder.Property(t => t.RequestTimestamp).HasColumnName("request_timestamp");
            builder.Property(t => t.ResponseContentType).HasColumnName("response_content_type").HasMaxLength(8000);
            builder.Property(t => t.ResponseStatusCode).HasColumnName("response_status_code").HasMaxLength(8000);
            builder.Property(t => t.ResponseTimestamp).HasColumnName("response_timestamp");
            builder.Property(t => t.ExecuteTime).HasColumnName("execute_time");
            builder.Property(t => t.UserId).HasColumnName("user_id");

            #region TD-1404
            builder.Property(t => t.CurrentUserIPAddress).HasColumnName("user_ip_address").HasMaxLength(45);
            builder.Property(t => t.CurrentUserLogin).HasColumnName("user_login").HasMaxLength(40);
            #endregion

            builder.HasOne(t => t.User)
               .WithMany(t => t.Logs)
               .HasForeignKey(t => t.UserId)
               .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
