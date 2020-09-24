using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    public class ClientProfileMap : IEntityTypeConfiguration<ClientProfile>
    {

        public void Configure(EntityTypeBuilder<ClientProfile> builder)
        {
            //Primary key
            builder.HasKey(t => t.ClientProfileId);

            builder.ToTable("ClientProfile");

            builder.Property(t => t.FirstName).HasColumnName("FirstName").HasColumnType("varchar");
            builder.Property(t => t.MiddleName).HasColumnName("MiddleName").HasColumnType("varchar");
            builder.Property(t => t.LastName).HasColumnName("LastName").HasColumnType("varchar");
            builder.Property(t => t.Avatar).HasColumnName("Avatar");
            builder.Property(t => t.Position).HasColumnName("Position");
            builder.Property(t => t.OfficePhone).HasColumnName("OfficePhone");
            builder.Property(t => t.LastThumbprint).HasColumnName("LastThumbprint");
            builder.Property(t => t.HasDSSAccess).HasColumnName("HasDSSAccess").IsOptional();
            builder.Property(t => t.TokenSigningIsActive).HasColumnName("TokenSigningIsActive").IsOptional();
            builder.Property(t => t.DssSigningIsActive).HasColumnName("DssSigningIsActive").IsOptional();
            builder.Property(t => t.PersonalNumber).HasColumnName("PersonalNumber").IsOptional();


            //// Relationships
            builder.HasOptional(m => m.ApplicationUser)
                .WithOptionalPrincipal(e => e.ClientProfile)
                .Map(m => m.MapKey("ClientProfile_ClientProfileId"))
                .WillCascadeOnDelete(true);

            builder.HasOptional(ds => ds.DssAuthenticationData)
                .WithRequired(cl => cl.ClientProfile)
                .WillCascadeOnDelete(true);
        }

    }
}
