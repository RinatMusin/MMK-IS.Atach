using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class ClientMap : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            {
                builder.HasKey(t => t.ClientId);

                builder.ToTable("Client");

                builder.Property(t => t.Active).HasColumnName("Active");
                builder.Property(t => t.AllowedOrigin).HasColumnName("AllowedOrigin");
                builder.Property(t => t.ApplicationTypeId).HasColumnName("ApplicationTypeId");
                builder.Property(t => t.Name).HasColumnName("Name");
                builder.Property(t => t.RefreshTokenLifeTime).HasColumnName("RefreshTokenLifeTime");
                builder.Property(t => t.Secret).HasColumnName("Secret");

                builder.HasRequired(t => t.ApplicationType)
                    .WithMany(t => t.Clients)
                    .HasForeignKey(d => d.ApplicationTypeId);
            }
        }
    }
}