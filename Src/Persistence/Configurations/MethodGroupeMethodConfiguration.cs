using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    class MethodGroupeMethodConfiguration : IEntityTypeConfiguration<MethodGroupeMethod>
    {
        public void Configure(EntityTypeBuilder<MethodGroupeMethod> builder)
        {
            builder.HasKey(t => t.MethodGroupeMethodId);

            builder.ToTable("Method_Groupe_Method");

            builder.HasOne(t => t.MethodGroupe).WithOne().IsRequired();
            builder.HasOne(t => t.MethodGroupe)
                .WithMany(t => t.MethodGroupeMethods)
                .HasForeignKey(t => t.MethodGroupeId);

            builder.HasOne(t => t.RouteMethod).WithOne().IsRequired();
            builder.HasOne(t => t.RouteMethod)
                .WithMany(t => t.MethodGroupeMethods)
                .HasForeignKey(t => t.RouteMethodId);
        }
    }
}
