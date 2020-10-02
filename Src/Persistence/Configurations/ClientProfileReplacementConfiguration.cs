using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class ClientProfileReplacementConfiguration : IEntityTypeConfiguration<ClientProfileReplacement>
    {
        public void Configure(EntityTypeBuilder<ClientProfileReplacement> builder)
        {
            builder.HasKey(t => t.ReplacementId);

            builder.ToTable("ClientProfile_Replacement");

            builder.Property(t => t.UserId).HasColumnName("UserId");
            builder.Property(t => t.UserReplacementId).HasColumnName("UserReplacementId");
            builder.Property(t => t.EndTime).HasColumnName("EndTime");
            builder.Property(t => t.StartTime).HasColumnName("StartTime");
            builder.Property(t => t.IsDisabled).HasColumnName("IsDisabled");

            builder.HasOne(t => t.User).WithOne().IsRequired();
            builder.HasOne(t => t.User)
                .WithMany(t => t.ReplacementUsers)
                .HasForeignKey(t => t.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.UserReplacement).WithOne().IsRequired();
            builder.HasOne(t => t.UserReplacement)
                .WithMany(t => t.ClientProfileReplacements)
                .HasForeignKey(t => t.UserReplacementId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
