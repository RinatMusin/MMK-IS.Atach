using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class RouteStepTemplateMap : IEntityTypeConfiguration<RouteStepTemplate>
    {
        public void Configure(EntityTypeBuilder<RouteStepTemplate> builder)
        {
            builder.HasKey(t => t.RouteStepTemplateId);

            builder.ToTable("Route_Step_Template");

            builder.Property(t => t.RouteActionId).HasColumnName("RouteActionId");
            builder.Property(t => t.RouteTemplateId).HasColumnName("RouteTemplateId");
            builder.Property(t => t.RouteStepTypeId).HasColumnName("RouteStepTypeId");
            builder.Property(t => t.UserId).HasColumnName("UserId");
            builder.Property(t => t.DisplayOrder).HasColumnName("DisplayOrder");
            builder.Property(t => t.ParallelOrder).HasColumnName("ParallelOrder");

            builder.Property(t => t.Duration).HasColumnName("Duration");
            builder.Property(t => t.RouteStepGroupId).HasColumnName("RouteStepGroupId");
            builder.Property(t => t.IsEditable).HasColumnName("IsEditable");
            builder.Property(t => t.IsRequired).HasColumnName("IsRequired");
            builder.Property(t => t.IsVisible).HasColumnName("IsVisible");


            builder.HasRequired(t => t.RouteTemplate)
                .WithMany(t => t.RouteStepTemplates)
                .HasForeignKey(t => t.RouteTemplateId)
                .WillCascadeOnDelete(true);

            builder.HasOne(t => t.RouteAction)
                .WithMany(t => t.RouteStepTemplates)
                .HasForeignKey(t => t.RouteActionId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.User)
                .WithMany(t => t.RouteStepTemplates)
                .HasForeignKey(t => t.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasRequired(t => t.RouteStepType)
                .WithMany(t => t.RouteStepTemplates)
                .HasForeignKey(t => t.RouteStepTypeId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasRequired(t => t.RouteStepGroup)
                .WithMany(t => t.RouteStepTemplates)
                .HasForeignKey(t => t.RouteStepGroupId)
                .WillCascadeOnDelete(true);

            builder.HasOne(t => t.Group)
                .WithMany(t => t.RouteStepTemplates)
                .HasForeignKey(t => t.GroupId)
                .WillCascadeOnDelete(true);

            builder.HasOne(t => t.TargetType)
                .WithMany(t => t.RouteStepTemplates)
                .HasForeignKey(t => t.TargetTypeId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }

}
