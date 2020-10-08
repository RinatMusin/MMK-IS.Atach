using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class ClientProfileConfiguration : IEntityTypeConfiguration<ClientProfile>
    {

        public void Configure(EntityTypeBuilder<ClientProfile> builder)
        {
            //Primary key
            builder.HasKey(t => t.ClientProfileId);

            builder.ToTable("ClientProfile");

            builder.Property(t => t.FirstName).HasColumnName("FirstName").HasMaxLength(8000);
            builder.Property(t => t.MiddleName).HasColumnName("MiddleName").HasMaxLength(8000);
            builder.Property(t => t.LastName).HasColumnName("LastName").HasMaxLength(8000);
            builder.Property(t => t.Avatar).HasColumnName("Avatar");
            builder.Property(t => t.Position).HasColumnName("Position");
            builder.Property(t => t.OfficePhone).HasColumnName("OfficePhone");
            builder.Property(t => t.LastThumbprint).HasColumnName("LastThumbprint");
            builder.Property(t => t.HasDSSAccess).HasColumnName("HasDSSAccess").IsRequired(false);
            builder.Property(t => t.TokenSigningIsActive).HasColumnName("TokenSigningIsActive").IsRequired(false);
            builder.Property(t => t.DssSigningIsActive).HasColumnName("DssSigningIsActive").IsRequired(false);
            builder.Property(t => t.PersonalNumber).HasColumnName("PersonalNumber").IsRequired(false);


            //// Relationships
            builder.Ignore(m => m.ApplicationUser);
            //builder.HasOne(m => m.ApplicationUser).WithMany().HasForeignKey(e => e.ClientProfileId).OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(ds => ds.DssAuthenticationData).WithMany().HasForeignKey(t => t.ClientProfileId);// .WithOne(t=>t.ClientProfile).IsRequired().OnDelete(DeleteBehavior.Cascade);
            /*    this.HasOptional(ds => ds.DssAuthenticationData)
                .WithRequired(cl => cl.ClientProfile)
                .WillCascadeOnDelete(true);*/
        }

        /*builder.HasOne(t => t.Task).WithOne().IsRequired();
        builder.HasOne(t => t.Task)
                .WithMany(t => t.ChatMessagesQnt)
                .HasForeignKey(t => t.TaskId)
                .OnDelete(DeleteBehavior.Cascade);

        //   builder.HasOne(m => m.ApplicationUser).WithOptionalPrincipal(e => e.ClientProfile).Map(m => m.MapKey("ClientProfile_ClientProfileId")).OnDelete(DeleteBehavior.Cascade);

        //builder.Property(cl => cl.ClientProfile).WithOne().IsRequired();
        //builder.HasOne(ds => ds.DssAuthenticationData).WithMany().IsRequired(cl => cl.ClientProfile).OnDelete(DeleteBehavior.Cascade);
        /*TODO надо изменить
         * this.HasOptional(m => m.ApplicationUser)
            .WithOptionalPrincipal(e => e.ClientProfile)
            .Map(m => m.MapKey("ClientProfile_ClientProfileId"))
            .WillCascadeOnDelete(true);

        this.HasOptional(ds => ds.DssAuthenticationData)
            .WithRequired(cl => cl.ClientProfile)
            .WillCascadeOnDelete(true);*/


    }
}
