using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MMK_IS.Atach.Domain.Entities.Mapping
{
    public class RouteActionFieldMethodMap : IEntityTypeConfiguration<RouteActionFieldMethod>
    {
        public void Configure(EntityTypeBuilder<RouteActionFieldMethod> builder)
        {
            builder.HasKey(t => t.RouteActionFieldMethodId);

            builder.ToTable("Route_Action_Field_Method");

            builder.Property(t => t.RouteActionFieldId).HasColumnName("RouteActionFieldId");
            builder.Property(t => t.RouteMethodId).HasColumnName("RouteMethodId");


            builder.HasRequired(t => t.RouteActionField)
                .WithMany(t => t.RouteActionFieldMethods)
                .HasForeignKey(t => t.RouteActionFieldId)
                .WillCascadeOnDelete(true);

            builder.HasRequired(t => t.RouteMethod)
                .WithMany(t => t.RouteActionFieldMethods)
                .HasForeignKey(t => t.RouteMethodId)
                .WillCascadeOnDelete(true);

        }
    }
}
