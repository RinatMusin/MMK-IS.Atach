using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    class MethodGroupeMethodMap : IEntityTypeConfiguration<MethodGroupeMethod>
    {
        public void Configure(EntityTypeBuilder<MethodGroupeMethod> builder)
        {
            builder.HasKey(t => t.MethodGroupeMethodId);

            builder.ToTable("Method_Groupe_Method");

            builder.HasRequired(t => t.MethodGroupe)
                .WithMany(t => t.MethodGroupeMethods)
                .HasForeignKey(t => t.MethodGroupeId);

            builder.HasRequired(t => t.RouteMethod)
                .WithMany(t => t.MethodGroupeMethods)
                .HasForeignKey(t => t.RouteMethodId);
        }
    }
}
