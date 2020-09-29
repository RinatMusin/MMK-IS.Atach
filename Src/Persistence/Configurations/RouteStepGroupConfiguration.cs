using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MMK_IS.Atach.Domain.Entities;

namespace MMK_IS.Atach.Persistence.Configurations
{
    public class RouteStepGroupConfiguration : IEntityTypeConfiguration<RouteStepGroup>
    {
        public void Configure(EntityTypeBuilder<RouteStepGroup> builder)
        {
            builder.HasKey(t => t.RouteStepGroupId);

            builder.ToTable("Route_Step_Group");

            builder.Property(t => t.CardId).HasColumnName("CardId");
            builder.Property(t => t.AfterSendCardId).HasColumnName("AfterSendCardId");
            builder.Property(t => t.RouteStepTypeId).HasColumnName("RouteStepTypeId");
            builder.Property(t => t.Name).HasColumnName("Name");
            builder.Property(t => t.Duration).HasColumnName("Duration");
            builder.Property(t => t.DocumentStatusId).HasColumnName("DocumentStatusId");
            builder.Property(t => t.IsStepRequired).HasColumnName("IsStepRequired");
            builder.Property(t => t.OnInMethodGroupId).HasColumnName("OnInMethodGroupId");
            builder.Property(t => t.OnOutMethodGroupId).HasColumnName("OnOutMethodGroupId");
            builder.Property(t => t.RouteActionId).HasColumnName("RouteActionId");
            builder.Property(t => t.IsCreateInNewVersion).HasColumnName("IsСreateInNewVersion");
            builder.Property(t => t.IsParallelEditable).HasColumnName("IsParallelEditable");



            builder.Property(t => t.Card).IsRequired();
            builder.HasOne(t => t.Card)
                .WithMany(t => t.RouteStepGroups)
                .HasForeignKey(t => t.CardId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(t => t.AfterSendCard).IsRequired();
            builder.HasOne(t => t.AfterSendCard)
                .WithMany(t => t.AfterRouteStepGroups)
                .HasForeignKey(t => t.AfterSendCardId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(t => t.RouteStepType).IsRequired();
            builder.HasOne(t => t.RouteStepType)
                .WithMany(t => t.RouteStepGroups)
                .HasForeignKey(t => t.RouteStepTypeId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.RouteAction)
               .WithMany(t => t.OutRouteStepGroups)
               .HasForeignKey(t => t.RouteActionId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.OnInMethodGroup)
                .WithMany(t => t.RouteStepGroupsIn)
                .HasForeignKey(t => t.OnInMethodGroupId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.OnOutMethodGroup)
                .WithMany(t => t.RouteStepGroupsOut)
                .HasForeignKey(t => t.OnOutMethodGroupId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.DocumentStatus)
                 .WithMany(t => t.RouteStepGroups)
                 .HasForeignKey(t => t.DocumentStatusId)
                 .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
