using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class RefreshTokenConfiguration : IEntityTypeConfiguration<RefreshToken>
    {
        public void Configure(EntityTypeBuilder<RefreshToken> builder)
        {
            builder.HasKey(t => t.RefreshTokenId);

            builder.ToTable("RefreshToken");

            builder.Property(t => t.RefreshTokenId).HasMaxLength(128);
            builder.Property(t => t.Subject).HasColumnName("Subject").IsRequired();
            builder.Property(t => t.ClientId).HasColumnName("ClientId").IsRequired().HasMaxLength(128);
            builder.Property(t => t.ExpiresUtc).HasColumnName("ExpiresUtc");
            builder.Property(t => t.IssuedUtc).HasColumnName("IssuedUtc");
            builder.Property(t => t.ProtectedTicket).HasColumnName("ProtectedTicket").IsRequired();


            builder.HasOne(t => t.Client).WithOne().IsRequired();
            builder.HasOne(t => t.Client)
                .WithMany(t => t.RefreshTokens)
                .HasForeignKey(t => t.ClientId);

        }
    }

}
