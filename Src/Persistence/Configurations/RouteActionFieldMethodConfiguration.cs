using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class RouteActionFieldMethodConfiguration : IEntityTypeConfiguration<RouteActionFieldMethod>
    {
        public void Configure(EntityTypeBuilder<RouteActionFieldMethod> builder)
        {
            builder.HasKey(t => t.RouteActionFieldMethodId);

            builder.ToTable("Route_Action_Field_Method");

            builder.Property(t => t.RouteActionFieldId).HasColumnName("RouteActionFieldId");
            builder.Property(t => t.RouteMethodId).HasColumnName("RouteMethodId");


            builder.HasOne(t => t.RouteActionField).WithOne().IsRequired();
            builder.HasOne(t => t.RouteActionField)
                .WithMany(t => t.RouteActionFieldMethods)
                .HasForeignKey(t => t.RouteActionFieldId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.RouteMethod).WithOne().IsRequired();
            builder.HasOne(t => t.RouteMethod)
                .WithMany(t => t.RouteActionFieldMethods)
                .HasForeignKey(t => t.RouteMethodId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
